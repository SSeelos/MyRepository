using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class EnumClassExampleC : IExample
    {
        public void Execute()
        {
            var t = MyEnumClassA.EnumA1;
            var holder = new EnumHolderString();
            holder.Add(MyEnumClassA.EnumA1);
            holder.Add(MyEnumClassA.EnumA2);
            holder.Add(MyEnumClassA.EnumA3);

            var itemA1 = holder.MyEnumClasses[MyEnumClassA.EnumA1.Name];
            var itemA2 = holder.MyEnumClasses[MyEnumClassA.EnumA1.Name];
            var itemA3 = holder.MyEnumClasses[MyEnumClassA.EnumA1.Name];
        }
    }
}
