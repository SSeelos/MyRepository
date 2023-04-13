using System;
using System.Collections.Generic;

namespace MyLibrary_DotNETstd_2_1
{
    public abstract class _MyEnumHolder<T>
    {
        public Dictionary<T, _MyEnumClass> MyEnumClasses = new Dictionary<T, _MyEnumClass>();
        public abstract void Add(_MyEnumClass enumClass);
        public _MyEnumClass Get(T type) => MyEnumClasses[type];
        public void Delete(T type) => MyEnumClasses.Remove(type);
    }
    public class EnumHolderType : _MyEnumHolder<Type>
    {
        public override void Add(_MyEnumClass enumClass)
        {
            MyEnumClasses.Add(enumClass.GetType(), enumClass);
        }
        public _MyEnumClass Get(_MyEnumClass type)
        {
            return MyEnumClasses[type.GetType()];
        }
    }
    public class EnumHolderString : _MyEnumHolder<string>
    {
        public override void Add(_MyEnumClass enumClass)
        {
            MyEnumClasses.Add(enumClass.Name, enumClass);
        }
        public _MyEnumClass Get(_MyEnumClass en)
        {
            return MyEnumClasses[en.Name];
        }
    }
}
