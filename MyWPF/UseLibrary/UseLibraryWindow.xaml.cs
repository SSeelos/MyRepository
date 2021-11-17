using MyLibrary;
using MyLibrary.EventsAndDelegates_CodeMonkey;
using MyLibrary.MyDesignPrinciples;
using MyLibrary.MyJSON;
<<<<<<< HEAD
using MyLibrary.MyNeo4j;
=======
using MyLibrary.MyProcess;
using MyLibrary.Test;
using MyLibrary.Web;
using System;
>>>>>>> 4579333d76d523225eca9a5dcd5f9fec77685720
using System.Windows;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for UseLibraryWindow.xaml
    /// </summary>
    public partial class UseLibraryWindow : Window
    {
        private ProgramRunner programRunner = new ProgramRunner();
        public UseLibraryWindow()
        {
            InitializeComponent();
        }


        private void SOLID_Click(object sender, RoutedEventArgs e)
        {
            programRunner.RunProgram(new SolidProgram());
        }

        private void UnitValues_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.RunProgram(new UnitValuesProgram());

            this.programRunner.RunProgram(new UnitsNetProgram());
        }

        private void DesignPrinciples_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.RunProgram(new MyDesignPrinciplesProgram());
        }

        private void JSON_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.RunProgram(new JSONProgram());
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.RunProgram(new EventsClient());
        }
        private void Web_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.RunProgram(new WebProgram());
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.RunProgram(new TestProgram());
        }

        private void MyProcess_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.RunProgram(new MyProcessProgram());
        }

        private void Neo4j_Click(object sender, RoutedEventArgs e)
        {
            Neo4jProgram.Main();
        }
    }
}
