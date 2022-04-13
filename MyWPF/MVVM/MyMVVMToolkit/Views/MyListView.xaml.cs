using MyViewModelLibrary.ViewModels;
using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit.Views
{
    /// <summary>
    /// Interaction logic for MyListView.xaml
    /// </summary>
    public partial class MyListView : Window
    {
        public MyListView()
        {
            DataContext = new MyDataCollectionVM();
            InitializeComponent();
        }
    }
}
