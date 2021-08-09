using MyLibrary;
using MyLibrary.MyDesignPrinciples;
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

        private void UnitValues_Click(object sender, RoutedEventArgs e)
        {

            AllocConsole();
            UnitValuesProgram unitValuesProgram = new UnitValuesProgram();
        }

        private void TemplateMethod_Click(object sender, RoutedEventArgs e)
        {

            AllocConsole();
            var templateMethod = new MyDesignPrinciplesProgram();
        }
    }
}
