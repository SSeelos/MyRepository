using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyWPF.MVVM
{
    /// <summary>
    /// Interaction logic for MyBindedPropertyWindow.xaml
    /// </summary>
    public partial class MyView : Window
    {
        public MyView()
        {
            this.DataContext = new MyViewModel();
            InitializeComponent();
        }
    }

    public class MyViewModel : _MyViewModel
    {
        private int myProperty = 0;
        public int MyProperty
        {
            get { return myProperty; }

            set
            {
                this.myProperty = value;
                OnPropertyChanged();
            }
        }

        public ICommand MyCommand => new MyCommand(this);
    }

    public class MyCommand : _MyCommand<MyViewModel>
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
}
