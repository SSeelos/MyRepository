using System.Windows;
using System.Windows.Input;

namespace MyWPF.MVVM
{
    /// <summary>
    /// Interaction logic for MyMVVMWindow.xaml
    /// </summary>
    public partial class MyView : Window
    {

        public MyView()
        {
            this.DataContext = new MyViewModel();

            InitializeComponent();
        }

        private void Advanced_Click(object sender, RoutedEventArgs e)
        {
            new AdvancedWindow()
                .ShowDialog();
        }
    }
    public class MyViewModel : MyViewModelBase
    {
        private int myProperty = 0;
        public int MyProperty
        {
            get { return myProperty; }

            set
            {
                this.myProperty = value;
                OnPropertyChanged();
            }
        }

        public ICommand MyCommand => new MyCommand(this);
    }
}
