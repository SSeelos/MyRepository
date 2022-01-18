using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class EnumClassExampleA : IExample
    {
        public void Execute()
        {
            var enumClassA = new MyEnumClassA("A");
            var enumClassB = new MyEnumClassB("B");
            var holder = new EnumHolderType();
            holder.Add(enumClassA);
            holder.Add(enumClassB);

            var item = holder.MyEnumClasses[MyEnumClassA.EnumA1.GetType()];
        }
    }
}
