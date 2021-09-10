using System;
using System.Reflection;

namespace MyConsoleAppProject.MyEventsAndDelegates
{

    //Delegate: agreement between publisher and subscriber
    //determines signature and return type

    //1 Define Delegate
    //2 Define event based on the delegate
    //3 Raise event
    public class MyPublisher
    {
        public delegate void MyEventHandler(object source, EventArgs args);
        public event MyEventHandler EventTriggered;

        protected virtual void OnEventTriggered()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);

            EventTriggered?.Invoke(this, EventArgs.Empty);
        }

        public void TriggeringFunction(MyClass myClass)
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);

            myClass.SetField(MethodBase.GetCurrentMethod().Name);

            OnEventTriggered();
        }
    }


}
