using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.TemplateMethod
{
    public abstract class MyTemplate
    {
        //calls steps in specific order
        public void TemplateMethod1()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            AbstractStep1();
            Hook();
            OptionalStep1();
            OptionalStep2();

        }
        //can have several template methods
        public void TemplateMethod2()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            AbstractStep1();
            OptionalStep2();

        }

        //implemented by subclasses
        public abstract void AbstractStep1();

        //default implementation
        public virtual void OptionalStep1()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }
        //default implementation
        public virtual void OptionalStep2()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        //optional step with empty body
        public virtual void Hook() { }
    }

    public class DefaultClass : MyTemplate
    {
        public DefaultClass()
        {
            Console.WriteLine(this.GetType().Name);
        }
        public override void AbstractStep1()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

    }
    public class ConcreteClass : MyTemplate
    {
        public ConcreteClass()
        {
            Console.WriteLine(this.GetType().Name);
        }
        public override void AbstractStep1()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }
        public override void OptionalStep2()
        {
            Console.WriteLine("override " + MethodBase.GetCurrentMethod().Name);
        }
        public override void Hook()
        {
            Console.WriteLine("override " + MethodBase.GetCurrentMethod().Name);
        }

    }
}
