using MyLibrary;
using MyLibrary.EventsAndDelegates_CodeMonkey;
using MyLibrary.MyDesignPrinciples;
using MyLibrary.MyJSON;
using MyLibrary.MyProcess;
using MyLibrary.Test;
using MyLibrary.Web;
using System;
using System.Windows;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for UseLibraryWindow.xaml
    /// </summary>
    public partial class UseLibraryWindow : Window
    {
        private IProgram _currentProgram;
        public IProgram CurrentProgram
        {
            get { return _currentProgram; }
            set
            {
                if (_currentProgram != null)
                    _currentProgram.Close();

                _currentProgram = value;
            }
        }
        public UseLibraryWindow()
        {
            InitializeComponent();
        }
        private void RunProgram(IProgram program)
        {
            CurrentProgram = program;

            try
            {
                program.Run();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void SOLID_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new SolidProgram());
        }

        private void UnitValues_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new UnitValuesProgram());

            this.RunProgram(new UnitsNetProgram());
        }

        private void DesignPrinciples_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new MyDesignPrinciplesProgram());
        }

        private void JSON_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new JSONProgram());
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new EventsClient());
        }
        private void Web_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new WebProgram());
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new TestProgram());
        }

        private void MyProcess_Click(object sender, RoutedEventArgs e)
        {
            this.RunProgram(new MyProcessProgram());
        }
    }
}
