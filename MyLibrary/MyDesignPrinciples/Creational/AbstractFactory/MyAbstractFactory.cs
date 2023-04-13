using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.AbstractFactory
{
    /// <summary>
    /// provides an interface for creating objects in a superclass, 
    /// but allows subclasses to alter the type of objects that will be created.
    /// 
    /// can also be an interface
    /// </summary>
    public abstract class _MyAbstractFactory
    {
        public abstract IProduct _CreateProductA();
        public abstract IProduct _CreateProductB();
    }
}
