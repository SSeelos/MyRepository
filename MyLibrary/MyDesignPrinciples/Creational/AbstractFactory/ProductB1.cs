using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;
using System;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.AbstractFactory
{
    public class ProductB1 : IProduct
    {
        public void doSomething()
        {
            Console.WriteLine($"{this.GetType().Name}.{MethodBase.GetCurrentMethod().Name}");
        }
    }

}
