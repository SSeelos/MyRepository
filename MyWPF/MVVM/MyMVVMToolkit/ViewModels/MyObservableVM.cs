using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyWPF.MVVM.MyMVVMToolkit
{
    public class MyObservableVM : ObservableObject
    {
        public MyObservableVM()
        {
            MyCommand = new RelayCommand(myAction);
        }

        public ICommand MyCommand { get; }

        private int myProperty;
        public int MyProperty
        {
            get => myProperty;
            private set => SetProperty(ref myProperty, value);
        }


        private void myAction()
        {
            //use myProperty
        }
    }
}
