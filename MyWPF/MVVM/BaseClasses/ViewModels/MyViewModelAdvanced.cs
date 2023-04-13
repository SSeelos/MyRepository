using System.Collections.ObjectModel;

namespace MyWPF.MVVM
{
    public class MyViewModelAdvanced : _MyViewModel
    {
        public int MyPropertyA
        {
            get { return MyProperties.MyPropertyA; }

            set
            {
                MyProperties.MyPropertyA = value;
                OnPropertyChanged();
            }
        }
        public int MyPropertyB
        {
            get { return MyProperties.MyPropertyB; }

            set
            {
                MyProperties.MyPropertyB = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<int> List { get; set; } = new ObservableCollection<int>();

    }
    public static class MyProperties
    {
        public static int MyPropertyA { get; set; } = 12;
        public static int MyPropertyB { get; set; } = 1000;
    }
}
