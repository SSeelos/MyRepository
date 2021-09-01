using System;

namespace MyLibrary.MyDesignPrinciples.Iterator
{
    public interface IIterator
    {
        void GetNext();
        bool HasMore();
    }
    public class MyIteratorA : IIterator
    {
        private ICollection collection;
        private bool state;
        public MyIteratorA(ICollection collection)
        {
            this.collection = collection;
        }
        public void GetNext()
        {
            throw new NotImplementedException();
        }

        public bool HasMore()
        {
            throw new NotImplementedException();
        }
    }
    public class MyIteratorB : IIterator
    {
        private ICollection collection;
        private bool state;
        public MyIteratorB(ICollection collection)
        {
            this.collection = collection;
        }
        public void GetNext()
        {
            throw new NotImplementedException();
        }

        public bool HasMore()
        {
            throw new NotImplementedException();
        }
    }
}
