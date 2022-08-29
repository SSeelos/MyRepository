using System;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    class MyPrototypeClient
    {
        public static void Run()
        {
            var protoTypeA = new MyConcretePrototypeA("field", "fieldA");
            Console.WriteLine(protoTypeA.Output());

            _MyPrototype cloneA = protoTypeA.Clone();
            Console.WriteLine(cloneA.Output());

            var protoTypeB = new MyConcretePrototypeB("fieldA", "fieldB");
            Console.WriteLine(protoTypeB.Output());

            _MyPrototype cloneB = protoTypeB.Clone();
            Console.WriteLine(cloneB.Output());

            var protoTypeC = new MyConcretePrototypeC(protoTypeA, "fieldB");
            Console.WriteLine(protoTypeC.Output());

            _MyPrototype cloneC = protoTypeC.Clone();
            Console.WriteLine(cloneC.Output());
        }
    }
}
