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

            var iA1 = holder.MyEnumClasses[MyEnumClassA.EnumA1.GetType()];
            var iA2 = holder.Get(MyEnumClassA.EnumA1.GetType());
            var iA3 = holder.Get(MyEnumClassA.EnumA1);
        }
    }
}
