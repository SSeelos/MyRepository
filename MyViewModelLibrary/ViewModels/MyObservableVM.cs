using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyObservableVM : _MyObservableVM
    {
        public MyObservableVM()
        {
            MyRelayCommand = new RelayCommand(myAction);
        }

        public ICommand MyRelayCommand { get; }

        private int _myProperty;
        public int MyProperty
        {
            get => _myProperty;
            set => SetProperty(ref _myProperty, value);
        }


        private void myAction()
        {
            MyProperty = 100;
        }
    }
}
