using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyObservableVM : _MyObservableVM
    {
        public MyObservableVM()
        {
            MyRelayCommand = new RelayCommand(MyAction);
            MyRelayCommandLambda = new RelayCommand(() => MyProperty = "RelayCmdLambda");
        }

        public ICommand MyRelayCommand { get; }
        public ICommand MyRelayCommandLambda { get; }
        public ICommand MyVMCommand => new MyCommandVM(this);

        private string _myProperty;
        public string MyProperty
        {
            get => _myProperty;
            set => SetProperty(ref _myProperty, value);
        }


        private void MyAction()
        {
            MyProperty = "RelayCommand";
        }
    }
}
