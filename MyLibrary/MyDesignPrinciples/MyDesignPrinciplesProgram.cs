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

            BuildWithSequentialBuilder();

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

        private void BuildWithSequentialBuilder()
        {
            var builder = new MySequentialBuilder();
            IBuildPartA start = builder.Start();
            IBuildPartOptional A = start.BuildPartA("A");
            IBuildPartC B = A.BuildPartB("B");
            IBuildProduct C = B.BuildPartC("C");

            MySequentialProduct prod = C.GetProduct();
            var parts = prod.OutputParts();
            Console.WriteLine(parts);

        }
    }
}
