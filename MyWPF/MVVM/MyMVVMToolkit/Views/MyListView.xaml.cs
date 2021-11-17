using MyWPF.MVVM.Utils;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyWPF.MVVM.MyMVVMToolkit.Views
{
    /// <summary>
    /// Interaction logic for MyListView.xaml
    /// </summary>
    public partial class MyListView : Window
    {
        public MyListView()
        {
            InitializeComponent();
        }

        private void MyScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var scrollViewer = sender as ScrollViewer;
            scrollViewer.EnableMouseWheelScroll(e);
        }
    }
}
