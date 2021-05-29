using System;

namespace MyConsoleAppProject.MyEventsAndDelegates
{
    public class MyEventsProgram
    {
        public MyEventsProgram()
        {
            Console.WriteLine();
            Console.WriteLine("#");
            Console.WriteLine(this.GetType().Name);
            Console.Read();
        }
        public void Run()
        {

            var myClass = new MyClass();
            var publisher = new MyPublisher();
            var subscriber = new MySubscriber();

            publisher.EventTriggered += subscriber.OnEventTrigger;

            publisher.TriggeringFunction(myClass);


            var publisherArgs = new MyPublisherArgs();
            var subscriberArgs = new MySubscriberArgs();

            publisherArgs.EventTriggeredArgs += subscriberArgs.OnEventTriggerArgs;

            publisherArgs.TriggeringFunctionArgs(myClass);
        }
    }
}
