using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyLINQ
{
    internal class LinqWhere : IExample
    {
        private static Dictionary<string, MyPlainOldObject> dataSource = MyLinqProgram.dataSource;
        public void Execute()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            ExampleA();

            ExampleB();

            ExampleC();
        }

        private static void ExampleA()
        {

            IEnumerable<MyPlainOldObject> query
                = from data in dataSource
                  where data.Key == "Key1"
                  select data.Value;

            foreach (MyPlainOldObject plainOldObject in query)
            {
                Console.WriteLine("QueryItem: " + plainOldObject.MyPropertyA + plainOldObject.MyPropertyB);

            }
        }
        private static void ExampleB()
        {
            IEnumerable<MyPlainOldObject> query
                = from data in dataSource
                  where data.Value.MyPropertyA == "A1" && data.Value.MyPropertyB == "B2"
                  select data.Value;

            foreach (MyPlainOldObject plainOldObject in query)
            {
                Console.WriteLine("QueryItem: " + plainOldObject.MyPropertyA + plainOldObject.MyPropertyB);

            }
        }
        private static void ExampleC()
        {
            IEnumerable<MyPlainOldObject> query
                = from data in dataSource
                  where data.Value.MyPropertyA == "A1" || data.Value.MyPropertyB == "B2"
                  select data.Value;

            foreach (MyPlainOldObject plainOldObject in query)
            {
                Console.WriteLine("QueryItem: " + plainOldObject.MyPropertyA + plainOldObject.MyPropertyB);

            }
        }
    }
}
