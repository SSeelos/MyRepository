﻿using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyViewModelLibrary.ViewModels
{
    public class MyDataCollectionVM : _MyVM
    {
        public MyDataCollectionVM()
        {
            MyItemData_Collection.Add(new MyItemData() { DataA = "A1", DataB = "B1" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            MyItemData_Collection.Add(new MyItemData() { DataA = "A2", DataB = "B2" });
            UseDataCommand = new RelayCommand(UseData);
            ClickCommand = new RelayCommand(OnClick);
        }
        private int myVar;
        public int MyProperty
        {
            get => myVar;
            set => SetProperty(ref myVar, value);
        }
        private MyItemData _itemData;
        public MyItemData ItemData
        {
            get => _itemData;
            set => SetProperty(ref _itemData, value);
        }

        public ObservableCollection<MyItemData> MyItemData_Collection { get; } = new ObservableCollection<MyItemData>();

        public ICommand UseDataCommand { get; }
        public ICommand ClickCommand { get; }
        private void OnClick()
        {
            UseData();
        }
        private void UseData()
        {
            //new instance -> refresh display value (optional)
            ItemData = new MyItemData()
            {
                DataA = ItemData.DataA += "+",
                DataB = ItemData.DataB += "+",
            };
        }
    }

    public class MyItemData
    {
        public string DataA { get; set; } = string.Empty;
        public string DataB { get; set; } = string.Empty;

        public override string ToString()
        {
            return DataA + DataB + "(toString)";
        }
    }
}
