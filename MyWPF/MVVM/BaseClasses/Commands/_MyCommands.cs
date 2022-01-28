using System;
using System.Windows.Input;

namespace MyWPF.MVVM
{
    public abstract class _MyCommand<T> : ICommand where T : _MyViewModel
    {
        protected T viewModel;
        public _MyCommand(T viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }

}
