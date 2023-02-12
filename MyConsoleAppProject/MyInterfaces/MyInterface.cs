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

    /// <summary>
    /// interface that enforces implementation of a method with the same signature as IMyDuplicateB
    /// </summary>
    interface IMyDuplicateA
    {
        void MyDuplicateMethod();
    }
    /// <summary>
    /// interface that enforces implementation of a method with the same signature as IMyDuplicateA
    /// </summary>
    interface IMyDuplicateB
    {
        void MyDuplicateMethod();
    }

    interface IObservable
    {
        static event Action OnTriggeredStatic;
        void Trigger();

        virtual void TriggerStatic()
        {
            OnTriggeredStatic?.Invoke();
        }
    }
}
