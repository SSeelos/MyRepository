using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyLINQ
{
    internal class LinqOrdering : IExample
    {
        static Dictionary<string, MyPlainOldObject> dataSource = MyLinqProgram.dataSource;
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            foreach (KeyValuePair<string, MyPlainOldObject> keyValuePair in dataSource)
            {
                Console.WriteLine("QueryItem: " + keyValuePair.Key + keyValuePair.Value.MyPropertyA + keyValuePair.Value.MyPropertyB);

            }

            IEnumerable<KeyValuePair<string, MyPlainOldObject>> query
                = from data in dataSource
                  where data.Key == "Key1" || data.Key == "Key2"
                  orderby data.Key descending
                  select data;

            foreach (KeyValuePair<string, MyPlainOldObject> keyValuePair in query)
            {
                Console.WriteLine("QueryItem: " + keyValuePair.Key + keyValuePair.Value.MyPropertyA + keyValuePair.Value.MyPropertyB);

            }
        }
    }
}
