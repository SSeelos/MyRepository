using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyLINQ
{
    public class MyLinqProgram : IProgram
    {

        public static Dictionary<string, MyPlainOldObject> dataSource = new Dictionary<string, MyPlainOldObject>()
            {
                { "Key1", new MyPlainOldObject() { MyPropertyA = "A1", MyPropertyB = "B1"} },
                { "Key2", new MyPlainOldObject() { MyPropertyA = "A2", MyPropertyB = "B2"} },
                { "Key12", new MyPlainOldObject() { MyPropertyA = "A1", MyPropertyB = "B2"} },
                { "Key3", new MyPlainOldObject() { MyPropertyA = "A3", MyPropertyB = "B3"} },
            };
        public void Run()
        {
            var examples = new Examples(
                new LinqSelect(),
                new LinqWhere(),
                new LinqOrdering(),
                new LinqGroup());

            examples.Execute();

        }
    }
}
