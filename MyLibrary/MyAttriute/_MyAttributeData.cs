using System;
using System.Linq;

namespace MyLibrary_DotNETstd_2_1
{
    public abstract class _MyAttributeData
    {
        public MyEnum MyEnum { get; }
        public _MyAttributeData()
        {
            Type type = this.GetType();
            object[] attr = type.GetCustomAttributes(typeof(MyAttributeEn), true);

            if (attr.Count() > 0)
            {
                var t = (MyAttributeEn)attr[0];
                this.MyEnum = t._enum;
            }
        }
    }

    [MyAttributeEn(MyEnum.A)]
    public class MyAttributeData : _MyAttributeData
    {

    }
    public abstract class _MyAttributeDataT
    {
        public Type MyEnum { get; }
        public _MyAttributeDataT()
        {
            Type type = this.GetType();
            object[] attr = type.GetCustomAttributes(typeof(MyAttributeT), true);

            if (attr.Count() > 0)
            {
                var t = (MyAttributeT)attr[0];
                this.MyEnum = t._enumClass;
            }
        }
    }

    [MyAttributeT(typeof(MyEnumClassA))]
    public class MyAttributeDataT : _MyAttributeData
    {

    }
}
