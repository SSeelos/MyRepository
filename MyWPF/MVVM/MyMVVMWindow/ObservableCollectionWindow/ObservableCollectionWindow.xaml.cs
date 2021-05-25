using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MyWPF.MVVM
{
    /// <summary>
    /// Interaction logic for ObservableCollectionWindow.xaml
    /// </summary>
    public partial class ObservableCollectionWindow : Window
    {
        public ObservableCollectionWindow()
        {
            this.DataContext = new ObservableCollectionViewModel();
            InitializeComponent();
        }
    }
    public class ObservableCollectionViewModel : MyViewModelBase
    {
        public MyCollection myDatas { get; set; }

        public ICommand MyObservableCollectionCommand => new MyObservableCollectionCommand(this);

        public ObservableCollectionViewModel()
        {
            myDatas = new MyCollection(this);
        }
    }
    public class MyCollection : ObservableCollection<MyData>
    {
        public MyCollection(ObservableCollectionViewModel viewModel)
        {
            Add(new MyData(viewModel, "one", "two"));
            Add(new MyData(viewModel, "three", "four"));
        }
    }
    public class MyData : MyViewModelBase
    {
        public ObservableCollectionViewModel parentViewModel;
        private string myField;
        public string MyField { get => myField; set => myField = value; }

        private string myField2;
        public string MyField2 { get => myField2; set => myField2 = value; }

        public ICommand MyDataCommand => new MyDataCommand(this);
        public MyData(ObservableCollectionViewModel viewModel, string arg1, string arg2)
        {
            this.parentViewModel = viewModel;
            this.myField = arg1;
            this.myField2 = arg2;
        }

    }

    public class MyObservableCollectionCommand : MyCommandBase<ObservableCollectionViewModel>
    {
        public MyObservableCollectionCommand(ObservableCollectionViewModel viewModel)
            : base(viewModel)
        {

        }
        public override void Execute(object parameter)
        {
            viewModel.myDatas.Add(new MyData(viewModel, "five", "six"));
        }
    }
    public class MyDataCommand : MyCommandBase<MyData>
    {
        public MyDataCommand(MyData viewModel)
            : base(viewModel)
        {

        }
        public override void Execute(object parameter)
        {
            var parentVM = this.viewModel.parentViewModel;
            parentVM.myDatas.Add(new MyData(parentVM, "five", "six"));
        }
    }
}
