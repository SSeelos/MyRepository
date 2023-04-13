using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public partial class MyObservableVM : _MyVM, INotifyDataErrorInfo
    {
        public MyObservableVM()
        {
            MyRelayCommand = new RelayCommand(MyAction);
            MyRelayCommandLambda = new RelayCommand(() => MyProperty = "RelayCmdLambda");

            Func<bool> canExecuteCheck = () => MyPropertyNotify != "";
            MyRelayCommandCanExecute = new RelayCommand(() => MyPropertyNotify += "can execute", canExecuteCheck);
            //MyRelayCommandCanExecute.NotifyCanExecuteChanged();
            MyRelayCommandCanExecute.CanExecute(false);

            ResetCommand = new RelayCommand(Reset);
            MyObservablePropertyCommand = new RelayCommand(() => MyObservableProperty = "MyObservableProperty");


        }


        public ICommand ResetCommand { get; }
        public ICommand MyRelayCommand { get; }
        public ICommand MyRelayCommandLambda { get; }
        public ICommand MyObservablePropertyCommand { get; }
        public ICommand MyVMCommand => new MyCommandVM(this);
        public RelayCommand MyRelayCommandCanExecute { get; }

        private const string defaultValue = "default";
        private string _myProperty = defaultValue;
        public string MyProperty
        {
            get => _myProperty;
            set => SetProperty(ref _myProperty, value);
        }

        [ObservableProperty]
        string myObservableProperty = defaultValue;

        private string _myPropertyNotify;


        public string MyPropertyNotify
        {
            get => _myPropertyNotify;
            set
            {
                SetProperty(ref _myPropertyNotify, value);
                MyRelayCommandCanExecute.NotifyCanExecuteChanged();
            }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        private Dictionary<string, List<string>> _propertyErrors = new Dictionary<string, List<string>>();
        public bool HasErrors => _propertyErrors.Any();
        private string _myPropertyError;
        public string MyPropertyError
        {
            get => _myPropertyError;
            set
            {
                RemoveError(nameof(MyPropertyError));

                if (value == "")
                {
                    AddError(nameof(MyPropertyError), "cant be empty");
                    OnErrorsChanged(nameof(MyPropertyError));
                }
                else
                {
                    SetProperty(ref _myPropertyError, value);
                }
            }
        }

        private void AddError(string propertyName, string errormessage)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<string>());
            }
            _propertyErrors[propertyName].Add(errormessage);
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        private void RemoveError(string propertyName)
        {
            _propertyErrors.Remove(propertyName);
        }

        public MyObservableValidator MyObservableValidator { get; } = new MyObservableValidator() { MyValidatorProperty = defaultValue };


        private void MyAction()
        {
            MyProperty = "RelayCommand";
        }
        private void Reset()
        {
            MyProperty = defaultValue;
            MyObservableProperty = defaultValue;
            MyPropertyNotify = "";
            MyObservableValidator.MyValidatorProperty = defaultValue;
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return _propertyErrors.GetValueOrDefault(propertyName, new List<string>());
        }
    }
}
