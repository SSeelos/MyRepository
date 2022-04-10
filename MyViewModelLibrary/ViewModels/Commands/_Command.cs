using System;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public abstract class _Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter) => true;

        public abstract void Execute(object parameter);
    }
    public abstract class _Command<T> : ICommand where T : _MyVM
    {
        protected T viewModel;
        public event EventHandler CanExecuteChanged;
        public _Command(T viewModel)
        {
            this.viewModel = viewModel;
        }
        public virtual bool CanExecute(object parameter) => true;

        public abstract void Execute(object parameter);
    }
}
