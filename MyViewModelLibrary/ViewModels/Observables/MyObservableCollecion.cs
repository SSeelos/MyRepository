using System.Collections.ObjectModel;

namespace MyViewModelLibrary.ViewModels.Observables
{
    public class MyObservableCollecion<T> : ObservableCollection<T>
    {
        public T Data { get; set; }
        public MyObservableCollecion(T data)
        {
            this.Data = data;
        }
    }
}
