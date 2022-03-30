using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;
using System;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.AbstractFactory
{
    /// <summary>
    /// produce families of related objects 
    /// without specifying their concrete classes
    /// 
    /// can also be an interface
    /// </summary>
    public abstract class _MyAbstractFactory
    {
        public abstract IProduct _CreateProductA();
        public abstract IProduct _CreateProductB();
    }

    public class MyFactory0 : _MyAbstractFactory
    {
        public override IProduct _CreateProductA()
        {
            return new ProductA();
        }

        public override IProduct _CreateProductB()
        {
            return new ProductB();
        }
    }
    public class MyFactory1 : _MyAbstractFactory
    {
        public override IProduct _CreateProductA()
        {
            return new ProductA1();
        }

        public override IProduct _CreateProductB()
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
