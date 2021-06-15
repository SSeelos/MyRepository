using MyWPF.MVVM.MyMVVMToolkit;
using System.Windows;

namespace MyWPF.MVVM
{
    /// <summary>
    /// Interaction logic for MyMVVMWindow.xaml
    /// </summary>
    public partial class MyMVVMWindow : Window
    {

        public MyMVVMWindow()
        {
            InitializeComponent();
        }

        private void MyBasicMVVM(object sender, RoutedEventArgs e)
        {
            new MyView()
                .Show();
        }

        private void Advanced_Click(object sender, RoutedEventArgs e)
        {
            new AdvancedWindow()
                .ShowDialog();
        }

        private void MyObservableCollection_Click(object sender, RoutedEventArgs e)
        {
            new ObservableCollectionWindow()
                .Show();
        }

        private void MyMVVMToolkit_Click(object sender, RoutedEventArgs e)
        {
            new MyMVVMToolkitWindow()
                .ShowDialog();
        }
    }
}
