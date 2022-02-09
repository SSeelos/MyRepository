using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyTaskObservableVM : _MyObservableVM
    {


        private TaskNotifier<int>? _requestTask;

        public Task<int>? RequestTask
        {
            get => _requestTask;
            set => SetPropertyAndNotifyOnCompletion(ref _requestTask, value);
        }
        public void SimulateAsyncMethod()
        {
            //RequestTask = ...
        }

    }

    public class AsyncVM : ObservableObject
    {

        private TaskNotifier _myTask;
        public AsyncVM()
        {
            SimulateAsyncMethod_Command = new RelayCommand(SimulateAsyncMethod);
        }
        public Task MyTask
        {
            get => MyTask;
            private set => SetPropertyAndNotifyOnCompletion(ref _myTask, value);
        }
        public ICommand SimulateAsyncMethod_Command { get; }
        public void SimulateAsyncMethod()
        {
            MyTask = Task.Delay(1000);
        }
    }
}
