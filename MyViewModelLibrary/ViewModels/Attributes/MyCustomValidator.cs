using System.ComponentModel.DataAnnotations;

namespace MyViewModelLibrary.ViewModels
{
    public class MyValidationAttribute : ValidationAttribute
    {
        public string MyProperty { get; }
        public string Exclude { get; }
        public MyValidationAttribute(string myProperty, string exclude)
        {
            MyProperty = myProperty;
            Exclude = exclude;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            object instance = validationContext.ObjectInstance;
            object otherValue = instance.GetType().GetProperty(MyProperty).GetValue(instance);

            if (value == otherValue)
                return new ValidationResult("input excluded");

            return ValidationResult.Success;
        }
    }
}
