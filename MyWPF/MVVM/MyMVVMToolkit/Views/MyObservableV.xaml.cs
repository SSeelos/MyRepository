using MyViewModelLibrary.ViewModels;
using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit
{
    /// <summary>
    /// Interaction logic for MyMVVMToolkitWindow.xaml
    /// </summary>
    public partial class MyObservableV : Window
    {
        public MyObservableV()
        {
            DataContext = new MyObservableVM();
            InitializeComponent();
        }


    }
}
