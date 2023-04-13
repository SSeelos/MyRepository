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
            subscriber.Subscribe(publisher);

            publisher.InvokingFunction(myClass);

            var publisherArgs = new MyPublisherArgs();
            var subscriberArgs = new MySubscriberArgs();
            subscriberArgs.Subscribe(publisherArgs);

            publisherArgs.TriggeringFunctionArgs(myClass);
        }
    }
}
