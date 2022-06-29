using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyDependencyInjectionVM
    {
        IService _service;
        public MyDependencyInjectionVM(IService service)
        {
            _service = service;

            PressMe = new RelayCommand(MyAction);
        }
        public ICommand PressMe { get; }

        private void MyAction()
        {
            bool validate = _service.Validate();
        }
    }
}
