using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.State
{
    public interface IState
    {
        public MyContext Context { get; set; }
        void DoSomething();
        void SwitchState();

    }
    public class MyStateA : IState
    {
        public MyContext Context { get; set; }

        public void DoSomething()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
        }

        public void SwitchState()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            Context.ChangeState(new MyStateB());
        }

    }
    public class MyStateB : IState
    {
        public MyContext Context { get; set; }
        public void DoSomething()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
        }

        public void SwitchState()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            Context.ChangeState(new MyStateA());
        }
    }
}
