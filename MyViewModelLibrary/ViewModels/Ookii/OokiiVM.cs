using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class OokiiVM : _MyVM
    {
        private string _path;
        public string Path
        {
            get => _path;
            set => SetProperty(ref _path, value);
        }
        public OokiiVM()
        {
            FolderBrowserCmd = new RelayCommand(T);
        }
        public ICommand FolderBrowserCmd { get; private set; }

        private void T()
        {
            //var dialog = new ookii
        }
    }
}
