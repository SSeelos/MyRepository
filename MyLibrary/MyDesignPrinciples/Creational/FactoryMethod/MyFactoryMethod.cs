using System;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod
{
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
        public static class Factory
        {
            public static IProduct CreateDefault() => new DefaultProduct();
            public static IProduct CreateA() => new ProductA();
            public static IProduct CreateB() => new ProductB();
        }
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
