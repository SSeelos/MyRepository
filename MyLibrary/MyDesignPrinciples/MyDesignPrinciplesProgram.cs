using MyLibrary.MyDesignPrinciples.MyBuilderPattern;
using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples
{
    public class MyDesignPrinciplesProgram
    {
        public MyDesignPrinciplesProgram()
        {
            Run();
        }

        public void Run()
        {

            Singleton();

            TemplateMethodProgram();

            FactoryMethod();

            AbstractFactory();

            BuilderPattern();

            Prototype();
        }



        private void Singleton()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MySingleton.Instance.DoSomething();

            MySingleton.Instance.DoSomethingElse();
        }

        public void TemplateMethodProgram()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var defaultClass = new DefaultClass();
            defaultClass.TemplateMethod1();
            defaultClass.TemplateMethod2();

            var concreteCLass = new ConcreteClass();
            concreteCLass.TemplateMethod1();
        }

        public void FactoryMethod()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var creatorDef = new MyCreatorDefault();
            creatorDef.Operation();

            var creatorA = new MyCreatorA();
            creatorA.Operation();

            var creatorB = new MyCreatorB();
            creatorB.Operation();


        }

        public void AbstractFactory()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var factory0 = new MyFactory0();
            IProduct productA0 = factory0.createProductA();
            IProduct productB0 = factory0.createProductB();
            productA0.doSomething();
            productB0.doSomething();

            var factory1 = new MyFactory1();
            IProduct productA1 = factory1.createProductA();
            IProduct productB1 = factory1.createProductB();
            productA1.doSomething();
            productB1.doSomething();

        }

        public void BuilderPattern()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var builder = new MyBuilder("initPart", "firstPart");
            var director = new MyDirector() { Builder = builder };

            BuildProductWithBuilder(builder);

            BuildWithDirector(director);


            BuildWithPartBuilder();

            BuildWithFluentBuilder();

        }

        private void BuildProductWithBuilder(MyBuilder builder)
        {

            builder.BuildPartA()
                .BuildPartB()
                .BuildPartC("partC");

            MyProduct product = builder.GetProduct();
            var parts = product.OutputParts();
            Console.WriteLine(parts);


            builder.newProduct("secondPart");
            builder.BuildPartA();

            MyProduct newProd = builder.GetProduct();
            parts = newProd.OutputParts();
            Console.WriteLine(parts);
        }

        private void BuildWithDirector(MyDirector director)
        {
            director.buildVariableProduct();
            director.buildFullProduct("part C");
        }

        private void BuildWithPartBuilder()
        {
            var builder = new MyPartBuilder("initPart");
            var director = new MyPartDirector() { Builder = builder };

            director.buildFullPartProduct("partC");

            var prod = builder.GetProduct();
            var parts = prod.OutputParts();
            Console.WriteLine(parts);
        }

        private void BuildWithFluentBuilder()
        {
            var builder = new MyFluentBuilder();
            IBuildPartA start = builder.Start();
            IBuildPartBOrPartC A = start.BuildPartA("A");
            IBuildPartC B = A.BuildPartB_Optional("B (optional)");
            IGetProduct C = B.BuildPartC("C");

            MyFluentProduct prod = C.GetProduct();
            var parts = prod.OutputParts();
            Console.WriteLine(parts);


            MyFluentProduct prod2 = builder.Start()
                .BuildPartA("A2")
                .BuildPartC("C2")
                .GetProduct();

            Console.WriteLine(prod2.OutputParts());

        }
        private void Prototype()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var protoTypeA = new MyConcretePrototypeA("field", "fieldA");
            MyPrototype cloneA = protoTypeA.Clone();

            Console.WriteLine(cloneA.Output());

            var protoTypeB = new MyConcretePrototypeB("field", "fieldB");
            MyPrototype cloneB = protoTypeB.Clone();

            Console.WriteLine(cloneB.Output());
        }
    }
}
