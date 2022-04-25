using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public partial class MyObservableVM : _MyVM
    {
        public MyObservableVM()
        {
            MyRelayCommand = new RelayCommand(MyAction);
            MyRelayCommandLambda = new RelayCommand(() => MyProperty = "RelayCmdLambda");

            ResetCommand = new RelayCommand(Reset);
            MyObservablePropertyCommand = new RelayCommand(() => MyObservableProperty = "MyObservableProperty");
        }


        public ICommand ResetCommand { get; }
        public ICommand MyRelayCommand { get; }
        public ICommand MyRelayCommandLambda { get; }
        public ICommand MyObservablePropertyCommand { get; }
        public ICommand MyVMCommand => new MyCommandVM(this);

        private const string defaultValue = "default";
        private string _myProperty = defaultValue;
        public string MyProperty
        {
            get => _myProperty;
            set => SetProperty(ref _myProperty, value);
        }

        [ObservableProperty]
        string myObservableProperty = defaultValue;
        private void MyAction()
        {
            MyProperty = "RelayCommand";
        }
        private void Reset()
        {
            MyProperty = defaultValue;
            MyObservableProperty = defaultValue;
        }
    }
}
