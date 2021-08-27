using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit
{
    /// <summary>
    /// Interaction logic for MyMVVMToolkitWindow.xaml
    /// </summary>
    public partial class MyObservableView : Window
    {
        public MyObservableView()
        {
            //view model defined in separate library!
            InitializeComponent();
        }


    }
}
