using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.MyEventsAndDelegates
{
    public class MyPublisherArgs : MyPublisher
    {
        public delegate void MyEventHandlerArgs(object source, MyEventArgs args);
        public event MyEventHandlerArgs EventTriggeredArgs;
        protected virtual void OnTriggerArgs(MyClass myClass)
        {
            EventTriggeredArgs?.Invoke(this, new MyEventArgs() { MyProperty = myClass});
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
