using System.Windows;

namespace MyWPF.MVVM
{
    /// <summary>
    /// Interaction logic for AdvancedWindow.xaml
    /// </summary>
    public partial class AdvancedWindow : Window
    {
        public AdvancedWindow()
        {
            this.DataContext = new MyCommandViewModel("command model", new MyRelayCommand(null));

            InitializeComponent();
        }
    }
}
