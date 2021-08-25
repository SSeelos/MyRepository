using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.MyPrototype
{
    class MyPrototypeClient
    {
        public static void Run()
        {
            var protoTypeA = new MyConcretePrototypeA("field", "fieldA");
            Console.WriteLine(protoTypeA.Output());

            MyPrototype cloneA = protoTypeA.Clone();
            Console.WriteLine(cloneA.Output());

            var protoTypeB = new MyConcretePrototypeB("field", "fieldB");
            Console.WriteLine(protoTypeB.Output());

            MyPrototype cloneB = protoTypeB.Clone();
            Console.WriteLine(cloneB.Output());
        }
    }
}
