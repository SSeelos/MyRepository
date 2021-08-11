using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples
{
    //can also be an interface
    public abstract class MyAbstractFactory
    {
        public abstract IProduct createProductA();
        public abstract IProduct createProductB();
    }

    public class MyFactory0 : MyAbstractFactory
    {
        public override IProduct createProductA()
        {
            return new ProductA();
        }

        public override IProduct createProductB()
        {
            return new ProductB();
        }
    }
    public class MyFactory1 : MyAbstractFactory
    {
        public override IProduct createProductA()
        {
            return new ProductA1();
        }

        public override IProduct createProductB()
        {
            return new ProductB1();
        }
    }

    public class ProductA1 : IProduct
    {
        public void doSomething()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
    }
    public class ProductB1 : IProduct
    {
        public void doSomething()
        {
            Console.WriteLine(this.GetType().Name + ": " + MethodBase.GetCurrentMethod().Name);
        }
    }

}
