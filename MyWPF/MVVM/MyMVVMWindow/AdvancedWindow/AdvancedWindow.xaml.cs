using System.Windows;
using System.Windows.Input;

namespace MyWPF.MVVM
{
    /// <summary>
    /// Interaction logic for AdvancedWindow.xaml
    /// </summary>
    public partial class AdvancedWindow : Window
    {
        public AdvancedWindow()
        {
            this.DataContext = new MyAdvancedViewModel();

            InitializeComponent();
        }
    }
    public class MyAdvancedViewModel : MyViewModelBase
    {
        private string myProperty;
        public string MyProperty
        {
            get { return myProperty; }

            set
            {
                this.myProperty = value;
                OnPropertyChanged();
            }
        }
        public string myString { get; private set; }
        bool Check = true;
        public ICommand RelayCommand => new MyRelayCommand(param => this.Execute(), param => this.Check) ?? null;

        private void Execute()
        {
            this.myString = myProperty;
        }

    }
    public class CreateListItem : MyCommandBase<MyViewModelAdvanced>
    {

        public CreateListItem(MyViewModelAdvanced viewModel)
            : base(viewModel)
        {
            this.viewModel = viewModel;
        }


        public override void Execute(object parameter)
        {
            this.viewModel.List.Add(1);
        }
    }
}
