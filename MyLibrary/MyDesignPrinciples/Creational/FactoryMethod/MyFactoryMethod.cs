using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.FactoryMethod
{
    /// <summary>
    /// provides an interface for creating objects in a superclass, 
    /// but allows subclasses to alter the type of objects that will be created.
    /// </summary>
    public abstract class MyCreatorBase
    {
        public virtual void Operation()
        {
            IProduct product = myFactoryMethod();
            product.doSomething();
        }

        //Factory Method: can be abstract or virtual (default implementation)
        //public abstract IProduct myFactoryMethod();
        public virtual IProduct myFactoryMethod()
        {
            return new DefaultProduct();
        }
    }

    public class MyCreatorDefault : MyCreatorBase
    {
    }
    public class MyCreatorA : MyCreatorBase
    {
        public override IProduct myFactoryMethod()
        {
            return new ProductA();
        }
    }
    public class MyCreatorB : MyCreatorBase
    {
        public override IProduct myFactoryMethod()
        {
            return new ProductB();
        }
    }

    public interface IProduct
    {
        void doSomething();
    }
    public class DefaultProduct : IProduct
    {
        public void doSomething()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
    }
    public class ProductA : IProduct
    {
        public string property;
        public void doSomething()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
    }
    public class ProductB : IProduct
    {
        public void doSomething()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
    }
}
