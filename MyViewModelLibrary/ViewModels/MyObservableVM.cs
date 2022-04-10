using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyObservableVM : _MyVM
    {
        public MyObservableVM()
        {
            MyRelayCommand = new RelayCommand(MyAction);
            MyRelayCommandLambda = new RelayCommand(() => MyProperty = "RelayCmdLambda");

            ResetCommand = new RelayCommand(() => MyProperty = defaultValue);
        }
        public ICommand ResetCommand { get; }
        public ICommand MyRelayCommand { get; }
        public ICommand MyRelayCommandLambda { get; }
        public ICommand MyVMCommand => new MyCommandVM(this);

        private const string defaultValue = "default";
        private string _myProperty = defaultValue;
        public string MyProperty
        {
            get => _myProperty;
            set => SetProperty(ref _myProperty, value);
        }

        [ObservableProperty]
        private string? _myObservabelProperty;


        private void MyAction()
        {
            MyProperty = "RelayCommand";
        }
    }
}
