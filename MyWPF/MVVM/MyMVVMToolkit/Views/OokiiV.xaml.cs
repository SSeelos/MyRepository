using MyViewModelLibrary.ViewModels;
using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit.Views
{
    /// <summary>
    /// Interaction logic for OokiiV.xaml
    /// </summary>
    public partial class OokiiV : Window
    {
        public OokiiVM ViewModel;
        public OokiiV()
        {
            this.ViewModel = new OokiiVM();
            this.DataContext = ViewModel;

            InitializeComponent();
        }

        private void FolderBrowser_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog()
            {
                SelectedPath = ViewModel.Path
            };

            if (!(bool)dlg.ShowDialog()) return;

            ViewModel.Path = dlg.SelectedPath;
        }
    }
}
