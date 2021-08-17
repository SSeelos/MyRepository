using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.MyDecorator
{
    //defines operations that can be altered by decorators
    public interface IComponent
    {
        void Execute();
    }

    //define wrapping interface
    public abstract class MyBaseDecorator : IComponent
    {
        protected IComponent component;
        public MyBaseDecorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            component.Execute();
        }
    }

    //call methods on wrapped object
    public class MyDecoratorA : MyBaseDecorator
    {
        public MyDecoratorA(IComponent component) : base(component)
        {
        }

        public override void Execute()
        {
            base.Execute();

            Method();
        }
        public void Method()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());


        }
    }
    public class MyDecoratorB : MyBaseDecorator
    {
        public MyDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Execute()
        {
            Method();

            base.Execute();
        }
        public void Method()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());


        }
    }

    //default implementations for operations
    public class MyComponent : IComponent
    {
        private string field;

        public MyComponent(string field)
        {
            this.field = field;
        }
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
        }
        public void Method()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            Console.WriteLine(field);

        }
    }

    public class MyManager
    {
        private IComponent Component;

        public MyManager(IComponent Component)
        {
            this.Component = Component;
        }

        public void UseComponent()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            Component.Execute();
        }
    }
}
