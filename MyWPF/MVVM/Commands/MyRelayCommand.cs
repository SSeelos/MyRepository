using System;
using System.Windows.Input;

namespace MyWPF.MVVM
{
    //bindings were established on the Command property
    //of Hyperlink, Button, and MenuItem controls displayed in the UI.
    //Those bindings ensure that when the user clicks on the controls,
    //ICommand objects exposed by the ViewModel execute.

    //When a ViewModel exposes an instance property of type I­Command,
    //the command object typically uses that ViewModel object to get its job done

    //However, creating a nested class that implements ICommand for each command exposed by a ViewModel
    //can bloat the size of the ViewModel class.

    //RelayCommand allows you to inject the command's logic via delegates passed into its constructor.
    public class MyRelayCommand : ICommand
    {
        readonly Action<object> execute;
        readonly Predicate<object> canExecute;

        public MyRelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }
        public MyRelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException("execute");
            this.canExecute = canExecute ?? throw new ArgumentNullException("canExecute");
        }


        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        //CanExecuteChanged delegates the event subscription to the CommandManager.RequerySuggested event.
        //This ensures that the WPF commanding infrastructure asks all RelayCommand objects
        //if they can execute whenever it asks the built-in commands.
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
