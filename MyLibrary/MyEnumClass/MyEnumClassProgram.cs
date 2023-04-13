using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary_DotNETstd_2_1
{

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
