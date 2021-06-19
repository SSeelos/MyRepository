using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyObservableVM : ObservableObject
    {
        public MyObservableVM()
        {
            MyRelayCommand = new RelayCommand(myAction);
        }

        public ICommand MyRelayCommand { get; }

        private int myProperty;
        public int MyProperty
        {
            get => myProperty;
            set => SetProperty(ref myProperty, value);
        }


        private void myAction()
        {
            MyProperty = 100;
        }
    }
}
