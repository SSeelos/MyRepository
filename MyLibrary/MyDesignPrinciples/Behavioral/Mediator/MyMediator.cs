namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Behavioral.Mediator
{
    public class MyMediator : IMyMediator
    {
        MyComponentA _myComponentA { get; set; }
        MyComponentB _myComponentB { get; set; }
        public MyMediator()
        {
            _myComponentA = new MyComponentA(this);
            _myComponentB = new MyComponentB(this);
        }

        public void Notify(_Component sender)
        {
            if (sender is MyComponentA)
            {
                //communicate to other component
                _myComponentB.ReceiveOrder();
            }
            if (sender is MyComponentB)
            {
                _myComponentA.ReceiveOrder();
            }
        }
    }
}
