﻿using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.AbstractFactory
{
    class MyAbstractFactoryClient
    {
        public static void Run()
        {
            var factory0 = new MyFactoryA();
            IProduct productA0 = factory0._CreateProductA();
            IProduct productB0 = factory0._CreateProductB();
            productA0.doSomething();
            productB0.doSomething();

            var factory1 = new MyFactoryB();
            IProduct productA1 = factory1._CreateProductA();
            IProduct productB1 = factory1._CreateProductB();
            productA1.doSomething();
            productB1.doSomething();
        }
    }
}
