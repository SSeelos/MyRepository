using MyConsoleAppProject;
using MyWPF.MVVM;
using System.Runtime.InteropServices;
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
            AllocConsole();

            new UseLibraryWindow()
                .ShowDialog();
        }

        private void MyConsoleApp_Click(object sender, RoutedEventArgs e)
        {
            AllocConsole();
            new MyProgram();
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
