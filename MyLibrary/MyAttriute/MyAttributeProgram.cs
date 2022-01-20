

using System;

namespace MyLibrary
{
    public class MyAttributeProgram : IProgram
    {
        public void Run()
        {
           var data = new MyAttributeData();

            var t = data.MyEnum;

            var dataT = new MyAttributeDataT();

            MyEnum tT = dataT.MyEnum;
        }
    }

}
