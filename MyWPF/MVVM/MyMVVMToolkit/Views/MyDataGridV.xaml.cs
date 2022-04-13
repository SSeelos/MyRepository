using MyViewModelLibrary.ViewModels;
using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit.Views
{
    /// <summary>
    /// Interaction logic for MyDataGridV.xaml
    /// </summary>
    public partial class MyDataGridV : Window
    {
        public MyDataGridV()
        {
            this.DataContext = new MyDataCollectionVM();
            InitializeComponent();
        }
    }
}
