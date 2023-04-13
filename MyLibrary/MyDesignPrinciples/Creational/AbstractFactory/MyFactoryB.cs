using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.AbstractFactory
{
    public class MyFactoryB : _MyAbstractFactory
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

}
