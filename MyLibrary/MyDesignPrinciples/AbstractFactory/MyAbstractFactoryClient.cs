using MyLibrary.MyDesignPrinciples.FactoryMethod;

namespace MyLibrary.MyDesignPrinciples.AbstractFactory
{
    class MyAbstractFactoryClient
    {
        public static void Run()
        {
            var factory0 = new MyFactory0();
            IProduct productA0 = factory0.createProductA();
            IProduct productB0 = factory0.createProductB();
            productA0.doSomething();
            productB0.doSomething();

            var factory1 = new MyFactory1();
            IProduct productA1 = factory1.createProductA();
            IProduct productB1 = factory1.createProductB();
            productA1.doSomething();
            productB1.doSomething();
        }
    }
}
