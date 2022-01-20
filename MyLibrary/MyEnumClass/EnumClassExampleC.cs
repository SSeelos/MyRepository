using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class EnumClassExampleC : IExample
    {
        public void Execute()
        {
            var holder = new EnumHolderString();
            holder.Add(MyEnumClassA.EnumA1);
            holder.Add(MyEnumClassA.EnumA2);
            holder.Add(MyEnumClassA.EnumA3);

            var itemA1 = holder.MyEnumClasses[MyEnumClassA.EnumA1.Name];
            var iA1 = holder.Get(MyEnumClassA.EnumA1);
            var itemA2 = holder.MyEnumClasses[MyEnumClassA.EnumA2.Name];
            var iA21 = holder.Get(MyEnumClassA.EnumA2);
            var itemA3 = holder.MyEnumClasses[MyEnumClassA.EnumA3.Name];
            var iA31 = holder.Get(MyEnumClassA.EnumA3);
        }
    }
}
