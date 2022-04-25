using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for BasicsWindow.xaml
    /// </summary>
    public partial class BasicsWindow : Window
    {
        public BasicsWindow()
        {
            InitializeComponent();
        }
        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MethodBase.GetCurrentMethod().Name);
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.Log.Text += ((CheckBox)sender).Content;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var txt = ((CheckBox)sender).Content.ToString();
            var str = new StringBuilder(this.Log.Text);
            str.Replace(txt, "");

            this.Log.Text = str.ToString();
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

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Log.Text = this.MyTextBox.Text;
            this.MyTextBoxReadOnly.Text = this.MyTextBox.Text;
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
            new MyWindow()
                .Show();
        }
    }
}
