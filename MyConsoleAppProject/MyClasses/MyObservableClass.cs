using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleAppProject
{
    public class MyObservableClass : MyAbstractClass, IObservable
    {
        public MyObservableClass(string field) : base(field)
        {
        }

        public event Action OnTrigger;
        public override void MyAbstractMethod()
        {
            throw new NotImplementedException();
        }

        public void Trigger()
        {
            OnTrigger?.Invoke();
        }
    }
}
