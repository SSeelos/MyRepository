using MyMachineLearning;
using MyWPF.MVVM;
using System.Windows;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Basics_Click(object sender, RoutedEventArgs e)
        {
            new BasicsWindow()
                .ShowDialog();
        }



        private void MVVM_Click(object sender, RoutedEventArgs e)
        {
            new MyMVVMWindow()
                .ShowDialog();
        }

        private void UseLibrary_Click(object sender, RoutedEventArgs e)
        {
            new UseLibraryWindow()
                .ShowDialog();
        }

        private void MyMachineLearning_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
