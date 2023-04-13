using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.AbstractFactory
{
    public class MyFactoryA : _MyAbstractFactory
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

}
