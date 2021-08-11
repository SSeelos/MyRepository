using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples
{
    public abstract class MyFactoryBase
    {
        public virtual void Operation()
        {
            IProduct product = createProduct();
            product.doSomething();
        }

        //Factory Method: can be abstract or virtual (default implementation)
        //public abstract IProduct createProduct();
        public virtual IProduct createProduct()
        {
            return new DefaultProduct();
        }
    }

    public class MyFactoryDefault : MyFactoryBase
    {
    }
    public class MyFactoryA : MyFactoryBase
    {
        public override IProduct createProduct()
        {
            return new ProductA();
        }
    }
    public class MyFactoryB : MyFactoryBase
    {
        public override IProduct createProduct()
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
