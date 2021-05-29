using System;
using System.Reflection;

namespace MyConsoleAppProject.MyEventsAndDelegates
{
    public class MySubscriber
    {
        /// <summary>
        /// EventHandler
        /// </summary>
        /// <param name="source"></param>
        /// <param name="eventArgs"></param>
        public void OnEventTrigger(object source, EventArgs eventArgs)
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
    }
    public class MySubscriberArgs
    {
        public void OnEventTriggerArgs(object source, MyEventArgs eventArgs)
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name + "\n"
                + eventArgs.GetType().Name + ": " + eventArgs.MyProperty.GetType().Name);
        }
    }
}
