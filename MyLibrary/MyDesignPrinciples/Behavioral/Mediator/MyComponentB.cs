namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Behavioral.Mediator
{
    public class MyComponentB : _Component
    {
        public MyComponentB(IMyMediator mediator)
            : base(mediator)
        {
        }
        public void SendNotification()
        {
            _mediator.Notify(this);
        }
        public void ReceiveOrder()
        {
            //do something..
        }
    }
}
