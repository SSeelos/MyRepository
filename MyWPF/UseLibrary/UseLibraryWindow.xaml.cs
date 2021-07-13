using MyLibrary;
using System.Runtime.InteropServices;
using System.Windows;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for UseLibraryWindow.xaml
    /// </summary>
    public partial class UseLibraryWindow : Window
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();
        public UseLibraryWindow()
        {
            InitializeComponent();
        }

        private void SOLID_Click(object sender, RoutedEventArgs e)
        {
            AllocConsole();
            SolidProgram solidProgram = new SolidProgram();
        }



    }
}
