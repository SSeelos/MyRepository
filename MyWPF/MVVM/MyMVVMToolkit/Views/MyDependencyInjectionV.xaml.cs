using MyViewModelLibrary.ViewModels;
using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit.Views
{
    /// <summary>
    /// Interaction logic for MyDependencyInjectionVM.xaml
    /// </summary>
    public partial class MyDependencyInjectionV : Window
    {
        public MyDependencyInjectionV()
        {
            InitializeComponent();
            this.DataContext = DISource.Resolver(typeof(MyDependencyInjectionVM));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
