using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public abstract class _MyEnumClass
    {
        public string Name { get; protected set; }
    }
    public class MyEnumClassA : _MyEnumClass
    {
        public static MyEnumClassA EnumA1 = new MyEnumClassA("A1");
        public static MyEnumClassA EnumA2 = new MyEnumClassA("A2");
        public static MyEnumClassA EnumA3 = new MyEnumClassA("A3");


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

    public abstract class _MyEnumHolder<T>
    {
        public Dictionary<T, _MyEnumClass> MyEnumClasses = new Dictionary<T, _MyEnumClass>();
        public abstract void Add(_MyEnumClass enumClass);
        public _MyEnumClass Get(T type)
        {
            return MyEnumClasses[type];
        }
        public void Delete(T type)
        {
            MyEnumClasses.Remove(type);
        }
    }
    public class EnumHolderType : _MyEnumHolder<Type>
    {
        public override void Add(_MyEnumClass enumClass)
        {
            MyEnumClasses.Add(enumClass.GetType(), enumClass);
        }
    }
    public class EnumHolderString : _MyEnumHolder<string>
    {
        public override void Add(_MyEnumClass enumClass)
        {
            MyEnumClasses.Add(enumClass.Name, enumClass);
        }
    }
    public class MyEnumClassProgram : IProgram
    {
        public void Run()
        {
            var ex = new Examples(
                new EnumClassExampleA(),
                new EnumClassExampleB(),
                new EnumClassExampleC());

            ex.Execute();
        }
    }
}
