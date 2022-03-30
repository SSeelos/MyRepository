namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.State
{
    public class MyContext
    {
        IState state;

        public MyContext()
        {
            var initState = new MyStateA();
            SetState(initState);
        }
        public MyContext(IState state)
        {
            SetState(state);
        }
        public void ChangeState(IState state)
        {
            SetState(state);
        }
        private void SetState(IState state)
        {
            this.state = state;
            state.Context = this;
        }
        public void DoSomething()
        {
            state.DoSomething();
        }
        public void SwitchState()
        {
            state.SwitchState();
        }
    }
}
