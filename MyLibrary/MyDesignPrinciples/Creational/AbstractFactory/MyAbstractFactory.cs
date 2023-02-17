using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;

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
}
