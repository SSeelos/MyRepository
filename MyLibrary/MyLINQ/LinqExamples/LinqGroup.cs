using MyLibrary.MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MyLibrary.MyLINQ
{
    public class LinqGroup : IExample
    {
        private static Dictionary<string, MyPlainOldObject> dataSource = MyLinqProgram.dataSource;
        public void Execute()
        {
            ExampleA();

            ExampleB();
        }

        /// <summary>
        /// When you end a query with a group clause, 
        /// your results take the form of a list of lists. 
        /// Each element in the list is an object that has a Key member 
        /// and a list of elements that are grouped under that key. 
        /// </summary>
        private void ExampleA()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            IEnumerable<IGrouping<string, KeyValuePair<string, MyPlainOldObject>>> query
                = from data in dataSource
                  group data by data.Value.MyPropertyA;

            foreach (IGrouping<string, KeyValuePair<string, MyPlainOldObject>> grouping in query)
            {
                Console.WriteLine("Grouping: " + grouping.Key);
                foreach (KeyValuePair<string, MyPlainOldObject> item in grouping)
                {
                    Console.WriteLine("Item: " + item.Key + item.Value.MyPropertyA + item.Value.MyPropertyB);
                }
            }
        }

        private void ExampleB()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            IEnumerable<IGrouping<string, KeyValuePair<string, MyPlainOldObject>>> query
                = from data in dataSource
                  group data by data.Value.MyPropertyB
                        into dataGroup
                  select dataGroup;

            foreach (IGrouping<string, KeyValuePair<string, MyPlainOldObject>> grouping in query)
            {
                Console.WriteLine("Grouping: " + grouping.Key);

                foreach (KeyValuePair<string, MyPlainOldObject> item in grouping)
                {
                    Console.WriteLine("Item: " + item.Key + item.Value);
                }
            }

        }
    }
}
