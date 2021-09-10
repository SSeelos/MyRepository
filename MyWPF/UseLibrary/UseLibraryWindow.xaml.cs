using MyLibrary;
using MyLibrary.EventsAndDelegates_CodeMonkey;
using MyLibrary.MyDesignPrinciples;
using MyLibrary.MyJSON;
using System.Windows;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for UseLibraryWindow.xaml
    /// </summary>
    public partial class UseLibraryWindow : Window
    {
        public UseLibraryWindow()
        {
            InitializeComponent();
        }

        private void SOLID_Click(object sender, RoutedEventArgs e)
        {
            var solidProgram = new SolidProgram();
        }

        private void UnitValues_Click(object sender, RoutedEventArgs e)
        {

            var unitValuesProgram = new UnitValuesProgram();
        }

        private void DesignPrinciples_Click(object sender, RoutedEventArgs e)
        {
            var templateMethod = new MyDesignPrinciplesProgram();
        }

        private void JSON_Click(object sender, RoutedEventArgs e)
        {
            JSONProgram.Run();
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            EventsClient.Run();
        }
    }
}
