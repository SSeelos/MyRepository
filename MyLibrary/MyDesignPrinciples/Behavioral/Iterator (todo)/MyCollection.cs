namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Iterator
{
    public interface ICollection
    {
        IIterator CreateIteratorA();
        IIterator CreateIteratorB();
    }
    class MyCollectionA : ICollection
    {
        public IIterator CreateIteratorA()
        {
            return new MyIteratorA(this);
        }
        public IIterator CreateIteratorB()
        {
            return new MyIteratorB(this);
        }
    }
}
