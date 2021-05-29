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

            MyViewModel viewModel = new MyViewModel();
            this.DataContext = viewModel;

            InitializeComponent();
        }

        private void Advanced_Click(object sender, RoutedEventArgs e)
        {
            new AdvancedWindow()
                .ShowDialog();
        }
    }
}
