using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class MyAttribute : Attribute
    {
        public _MyEnumClass _enumClass { get; private set; }
        public MyAttribute(_MyEnumClass myEnumClass)
        {
            this._enumClass = myEnumClass;
        }
    }
    public class MyAttributeT : Attribute
    {
        public Type _enumClass { get; private set; }
        public MyAttributeT(Type myEnumClass)
        {
            this._enumClass = myEnumClass.GetType();
        }
    }
    public enum MyEnum
    {
        A,
        B,
        C,
    }
    public class MyAttributeEn : Attribute
    {
        public MyEnum _enum { get; private set; }
        public MyAttributeEn(MyEnum myEnum)
        {
            this._enum = myEnum;
        }
    }
    public class MyAttributeInt : Attribute
    {
        public int _enum { get; private set; }
        public MyAttributeInt(int myEnum)
        {
            this._enum = myEnum;
        }
    }
    public class MyAttributeString : Attribute
    {
        public string _enum { get; private set; }
        public MyAttributeString(string myEnum)
        {
            this._enum = myEnum;
        }
    }




}
