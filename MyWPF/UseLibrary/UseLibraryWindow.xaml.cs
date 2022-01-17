using MyLibrary;
using MyLibrary.EventsAndDelegates_CodeMonkey;
using MyLibrary.MyBitMap;
using MyLibrary.MyDesignPrinciples;
using MyLibrary.MyJSON;
using MyLibrary.MyProcess;
using MyLibrary.Test;
using MyLibrary.Web;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media.Imaging;

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

        private void Bitmap_Click(object sender, RoutedEventArgs e)
        {
            var resUri = new Uri("pack://application:,,,/MyWPF;component/Resources/Amelie.png");

            BitmapImage bitmapImageUri;
            try
            {
                bitmapImageUri = new BitmapImage(resUri);
            }
            catch { }

            Bitmap bitmap = Properties.Resources.Amelie;

            //BitmapImage bitmapImage = BitmapConverter.Bitmap2BitmapImage(bitmap);

            var bMimage = bitmap.ToBitmapImage();



            this.programRunner.RunProgram(new MyBitMapProgram());
        }
    }
}
