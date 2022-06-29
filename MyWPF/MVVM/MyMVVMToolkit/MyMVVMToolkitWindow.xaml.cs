using Autofac;
using MyViewModelLibrary.ViewModels;
using MyWPF.MVVM.MyMVVMToolkit.Views;
using System;
using System.Windows;

namespace MyWPF.MVVM.MyMVVMToolkit
{
    /// <summary>
    /// Interaction logic for MyMVVMToolkitWindow.xaml
    /// </summary>
    public partial class MyMVVMToolkitWindow : Window
    {
        public MyMVVMToolkitWindow()
        {
            InitializeComponent();
        }


        private void ObservableVM_Click(object sender, RoutedEventArgs e)
        {
            new MyObservableV()
                .Show();
        }

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            new MyListView()
                .Show();
        }

        private void DataGridView_Click(object sender, RoutedEventArgs e)
        {
            new MyDataGridV()
                .Show();
        }

        private void Ookii_Click(object sender, RoutedEventArgs e)
        {
            new OokiiV()
                .Show();
        }

        private void DependencyInjection_Click(object sender, RoutedEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MyDependencyInjectionVM>();
            builder.RegisterType<MyService>().As<IService>();
            IContainer container = builder.Build();
            Type type = typeof(MyDependencyInjectionVM);
            Func<Type, object> resolver = (type) => { return container.Resolve(type); };
            DISource.Resolver = resolver;

            new MyDependencyInjectionV()
                .Show();
        }
    }
}
