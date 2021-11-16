namespace MyLibrary.EventsAndDelegates_CodeMonkey
{
    public class EventsClient : IProgram
    {
        public void Run()
        {
            var publisher = new MyPublisher();

            var subscriberA = new MySubscriberA();
            subscriberA.Subscribe(publisher);
            var subscriberB = new MySubscriberB();
            subscriberB.Subscribe(publisher);

            publisher.TriggerALL();
        }
    }
}
