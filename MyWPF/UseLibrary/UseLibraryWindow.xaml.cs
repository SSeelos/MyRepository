using MyLibrary_DotNETstd_2_1;
using MyLibrary_DotNETstd_2_1.EventsAndDelegates_CodeMonkey;
using MyLibrary_DotNETstd_2_1.MyBitMap;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples;
using MyLibrary_DotNETstd_2_1.MyJSON;
using MyLibrary_DotNETstd_2_1.MyLINQ;
using MyLibrary_DotNETstd_2_1.MyProcess;
using MyLibrary_DotNETstd_2_1.Test;
using MyLibrary_DotNETstd_2_1.Web;
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
            programRunner.Run(new SolidProgram());
        }

        private void UnitValues_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new UnitValuesProgram());

            this.programRunner.Run(new UnitsNetProgram());
        }

        private void DesignPrinciples_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new MyDesignPrinciplesProgram());
        }

        private void JSON_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new JSONProgram());
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new EventsClient());
        }
        private void Web_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new WebProgram());
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new TestProgram());
        }

        private void MyProcess_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new MyProcessProgram());
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



            this.programRunner.Run(new MyBitMapProgram());
        }
        private void LINQ_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new MyLinqProgram());
        }

        private void EnumClass_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new MyEnumClassProgram());
        }

        private void Attributes_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new MyAttributeProgram());
        }

        private void FileSystem_Click(object sender, RoutedEventArgs e)
        {
            //this.programRunner.RunProgram(new FileSystemProgram());
        }


        private void MyEncoding_Click(object sender, RoutedEventArgs e)
        {
            this.programRunner.Run(new MyEncodingProgram());

        }
    }
}
