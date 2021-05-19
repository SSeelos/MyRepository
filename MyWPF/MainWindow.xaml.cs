using MyWPF.MVVM;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MethodBase.GetCurrentMethod().Name);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.MyTextBoxReadOnly.Text += ((CheckBox)sender).Content;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var txt = ((CheckBox)sender).Content.ToString();
            var str = new StringBuilder(this.MyTextBoxReadOnly.Text);
            str.Replace(txt, "");

            this.MyTextBoxReadOnly.Text = str.ToString();
        }

        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = (ComboBox)sender;
            var value = (ComboBoxItem)box.SelectedValue;

            this.Log.Text = value.Content.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MethodBase.GetCurrentMethod().Name);
        }

        private void MyTextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Log.Text = this.MyTextBlock.Text;
        }

        private void OpenPage_Click(object sender, RoutedEventArgs e)
        {
            var page = new MyPage();

            var navWindow = new NavigationWindow();
            navWindow.Show();
            navWindow.Navigate(page);
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            new MyWindow().Show();
        }

        private void MVVM_Click(object sender, RoutedEventArgs e)
        {
            new MyMVVMWindow().ShowDialog();
        }
    }
}
