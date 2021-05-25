using System;
using System.Windows.Input;

namespace MyWPF.MVVM
{
    public abstract class MyCommandBase<T> : ICommand where T : MyViewModelBase
    {
        protected T viewModel;
        public MyCommandBase(T viewModel)
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
