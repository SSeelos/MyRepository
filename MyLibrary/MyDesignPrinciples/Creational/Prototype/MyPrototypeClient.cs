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

            var subA = new MySubAPrototype(protoTypeA, "fieldAA");
            Console.WriteLine(protoTypeA.Output());
            _MyPrototype cloneSubA = subA.Clone();
            Console.WriteLine(cloneSubA.Output());

            var protoTypeB = new MyConcretePrototypeB("fieldA", "fieldB");
            Console.WriteLine(protoTypeB.Output());
            _MyPrototype cloneB = protoTypeB.Clone();
            Console.WriteLine(cloneB.Output());

            var subB = new MySubBPrototype(protoTypeB, "fieldBA");
            Console.WriteLine(subB.Output());
            _MyPrototype cloneSubB = subB.Clone();
            Console.WriteLine(cloneSubB.Output());

            var protoTypeC = new MyConcretePrototypeC(protoTypeA, "field");
            Console.WriteLine(protoTypeC.Output());
            _MyPrototype cloneC = protoTypeC.Clone();
            Console.WriteLine(cloneC.Output());

            var subC = new MySubCPrototype(protoTypeA, "field", "fieldCA");
            Console.WriteLine(subC.Output());
            _MyPrototype cloneSubC = subC.Clone();
            Console.WriteLine(cloneSubC.Output());
        }
    }
}
