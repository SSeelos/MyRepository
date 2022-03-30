using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary_DotNETstd_2_1
{
    public abstract class _MyEnumClass
    {
        public string Name { get; protected set; }
    }
    public class MyEnumClassA : _MyEnumClass
    {
        public static _MyEnumClass EnumA1 = new MyEnumClassA("A1");
        public static _MyEnumClass EnumA2 = new MyEnumClassA("A2");
        public static _MyEnumClass EnumA3 = new MyEnumClassA("A3");


        public MyEnumClassA(string name)
        {
            this.Name = name;
        }
    }
    public class MyEnumClassB : _MyEnumClass
    {
        public MyEnumClassB(string name)
        {
            this.Name = name;
        }
    }
    public static class MyEnumClassContainer
    {
        public class MyEnumClassC : _MyEnumClass { }
        public class MyEnumClassD : _MyEnumClass { }
    }
    public class MyEnumClassConst:_MyEnumClass
    {
        public const string Name = "A";
    }


}
