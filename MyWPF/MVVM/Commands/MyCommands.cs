using System;
using System.Windows.Input;

namespace MyWPF.MVVM
{
    public abstract class MyCommandBase : ICommand
    {
        protected MyViewModel viewModel;
        public event EventHandler CanExecuteChanged;
        public MyCommandBase(MyViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }

    public class MyCommand : MyCommandBase
    {

        public MyCommand(MyViewModel viewModel)
            : base(viewModel)
        {
        }


        public override void Execute(object parameter)
        {
            this.viewModel.MyProperty = 100;
        }
    }
    public class CreateListItem : ICommand
    {
        private MyViewModelAdvanced windowViewModel;

        public event EventHandler CanExecuteChanged;

        public CreateListItem(MyViewModelAdvanced windowViewModel)
        {
            this.windowViewModel = windowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.windowViewModel.List.Add(1);
        }
    }
}
