using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleAppProject.MyEventsAndDelegates
{
    public class MyPublisherArgs : MyPublisher
    {
        public delegate void MyEventHandlerArgs(object source, MyEventArgs args);
        public event MyEventHandlerArgs OnEventTriggeredArgs;
        protected virtual void OnTriggerArgs(MyClass myClass)
        {
            OnEventTriggeredArgs?.Invoke(this, new MyEventArgs() { MyProperty = myClass });
        }
        public void TriggeringFunctionArgs(MyClass myClass)
        {
            OnTriggerArgs(myClass);
        }
    }

    public class MyEventArgs : EventArgs
    {
        public MyClass MyProperty { get; set; }
    }
}
