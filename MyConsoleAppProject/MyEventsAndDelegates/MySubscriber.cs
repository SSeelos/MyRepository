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
        public void OnEventTriggered(object source, EventArgs eventArgs)
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
        public void Subscribe(MyPublisher publisher)
        {
            publisher.OnEventTriggered += OnEventTriggered;
        }
    }

    public class MySubscriberArgs
    {
        public void OnEventTriggered(object source, MyEventArgs eventArgs)
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name + "\n"
                + eventArgs.GetType().Name + ": " + eventArgs.MyProperty.GetType().Name);
        }
        public void Subscribe(MyPublisherArgs publisher)
        {
            publisher.OnEventTriggeredArgs += OnEventTriggered;
        }
    }
}
