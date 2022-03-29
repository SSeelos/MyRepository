using System;

namespace MyViewModelLibrary.ViewModels
{
    public class MyCommandVM : _Command<MyObservableVM>
    {
        public MyCommandVM(MyObservableVM viewModel)
            : base(viewModel)
        {
        }

        public override void Execute(object parameter)
        {
            Console.WriteLine($"{GetType().Name} ViewModel: {viewModel.GetType().Name}");

            viewModel.MyProperty = "Command";
        }
    }
}
