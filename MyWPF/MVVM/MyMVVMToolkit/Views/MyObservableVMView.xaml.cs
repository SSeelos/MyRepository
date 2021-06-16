using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit
{
    /// <summary>
    /// Interaction logic for MyMVVMToolkitWindow.xaml
    /// </summary>
    public partial class MyObservableVMView : Window
    {
        public MyObservableVMView()
        {
            DataContext = new MyObservableVM();
            InitializeComponent();
        }


    }
}
