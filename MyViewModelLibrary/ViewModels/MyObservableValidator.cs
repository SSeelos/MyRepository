using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyViewModelLibrary.ViewModels
{
    public class MyObservableValidator : ObservableValidator
    {
        private string _myValidatorProperty;
        [Required(ErrorMessage = "required")]
        [MinLength(1)]
        [MaxLength(10)]
        [CustomValidation(typeof(MyObservableValidator), nameof(MyValidation))]
        public string MyValidatorProperty
        {
            get => _myValidatorProperty;
            set => SetProperty(ref _myValidatorProperty, value, validate: true);
        }
        public static ValidationResult ValidationResult { get; private set; }
        public static ValidationResult MyValidation(ValidationContext context)
        {
            var validator = context.ObjectInstance as MyObservableValidator;
            bool isValid = validator._myValidatorProperty != "";

            if (!isValid)
            {
                return ValidationResult = new("property not valid");

            }
            ValidationResult = ValidationResult.Success;
            return ValidationResult.Success;
        }
    }
    public interface IService
    {
        bool Validate();
    }
    public class MyService : IService
    {
        public bool Validate()
        {
            return true;
        }
    }
    public class MyObservableValidatorC : ObservableValidator
    {
        readonly IService _service;
        private string _myValidatorProperty;
        public MyObservableValidatorC(IService service)
        {
            _service = service;
        }

        [CustomValidation(typeof(MyObservableValidatorC), nameof(MyValidation))]
        public string MyValidatorProperty
        {
            get => _myValidatorProperty;
            set => SetProperty(ref _myValidatorProperty, value, validate: true);
        }
        public static ValidationResult MyValidation(ValidationContext context)
        {
            var validator = context.ObjectInstance as MyObservableValidatorC;

            if (!validator._service.Validate())
                return new("service not valid");

            return ValidationResult.Success;
        }
    }
}
