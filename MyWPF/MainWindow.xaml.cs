﻿using MyConsoleAppProject;
using MyDotNet6ConsoleApp;
using MyWPF.MVVM;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

namespace MyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowWindow(Window window)
        {
            try
            {
                window.ShowDialog();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Basics_Click(object sender, RoutedEventArgs e)
        {
            this.ShowWindow(new BasicsWindow());
        }



        private void MVVM_Click(object sender, RoutedEventArgs e)
        {
            this.ShowWindow(new MyMVVMWindow());
        }

        private void UseLibrary_Click(object sender, RoutedEventArgs e)
        {
            AllocConsole(Encoding.Unicode);

            this.ShowWindow(new UseLibraryWindow());
        }

        private void MyConsoleApp_Click(object sender, RoutedEventArgs e)
        {
            AllocConsole(Encoding.Unicode);

            new MyProgram();
        }
        private void DotNet6App_Click(object sender, RoutedEventArgs e)
        {
            AllocConsole(Encoding.Unicode);

            DotNET6Program.Main();
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void AllocConsole(Encoding encoding)
        {
            AllocConsole();
            Console.InputEncoding = encoding;
            Console.OutputEncoding = encoding;
        }

    }
}
