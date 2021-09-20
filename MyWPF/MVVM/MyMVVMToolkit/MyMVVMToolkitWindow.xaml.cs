using MyWPF.MVVM.MyMVVMToolkit.Views;
using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit
{
    /// <summary>
    /// Interaction logic for MyMVVMToolkitWindow.xaml
    /// </summary>
    public partial class MyMVVMToolkitWindow : Window
    {
        public MyMVVMToolkitWindow()
        {
            InitializeComponent();
        }


        private void ObservableVM_Click(object sender, RoutedEventArgs e)
        {
            new MyObservableView()
                .Show();
        }

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            new MyListView()
                .ShowDialog();
        }
    }
}
