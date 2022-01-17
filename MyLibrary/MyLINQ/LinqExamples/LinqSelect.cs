using MyLibrary.MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyLibrary.MyLINQ
{
    internal class LinqSelect : IExample
    {
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            Dictionary<string, MyPlainOldObject> dataSource = MyLinqProgram.dataSource;

            IEnumerable<KeyValuePair<string, MyPlainOldObject>> query
                = from data in dataSource
                  select data;

            foreach (KeyValuePair<string, MyPlainOldObject> keyValuePair in query)
            {
                Console.WriteLine("QueryItem: " + keyValuePair.Key + keyValuePair.Value.MyPropertyA + keyValuePair.Value.MyPropertyB);

            }
        }
    }
}
