using System.Collections;
using System.Collections.Generic;

namespace MyConsoleAppProject
{
    public class MyEnumerable : IEnumerable<string>
    {
        public IEnumerable<string> MyEnumerableData = new List<string>
        {
            "dataA",
            "dataB",
            "dataC"
        };
        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in MyEnumerableData)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
