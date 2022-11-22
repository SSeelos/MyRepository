using System.Collections;

namespace MyXUnitTestProject
{
    public abstract class _MyDataClass : IEnumerable<object[]>
    {
        protected IEnumerable<object[]> data { get; }
        public _MyDataClass(IEnumerable<object[]> data)
        {
            this.data = data;
        }
        public IEnumerator<object[]> GetEnumerator()
            => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
