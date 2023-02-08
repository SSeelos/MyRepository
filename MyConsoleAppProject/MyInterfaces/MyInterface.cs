using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleAppProject
{
    interface IMyInterfaceA
    {
        void MyInterfaceAMethod();
        virtual void MyVirtualInterfaceMethod()
        {
            //...
        }
    }

    interface IMyInterfaceB
    {
        void MyInterfaceBMethod();
    }
}
