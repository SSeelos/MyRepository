using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MyWPF.MVVM.MyMVVMToolkit
{
    public class MyObservableObject : ObservableObject
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
    }
}
