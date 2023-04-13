using Microsoft.Toolkit.Mvvm.Input;
using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyDependencyInjectionVM
    {
        IService _service;

        public ObservableCollection<MyPlainOldObject> Items { get; private set; }
        public MyPlainOldObject SelectedItem { get; set; }
        public MyDependencyInjectionVM(IService service)
        {
            _service = service;

            Items = new ObservableCollection<MyPlainOldObject>()
            {
                new MyPlainOldObject(){MyPropertyA="A", MyPropertyB ="B" },
                new MyPlainOldObject(){MyPropertyA="A1", MyPropertyB ="B1" }
            };

            PressMe = new RelayCommand(MyAction);
        }
        public ICommand PressMe { get; }

        private void MyAction()
        {
            bool validate = _service.Validate();
        }
    }
}
