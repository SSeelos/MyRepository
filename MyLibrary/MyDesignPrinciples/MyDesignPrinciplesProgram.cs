
using MyLibrary.MyDesignPrinciples.Adapter;
using MyLibrary.MyDesignPrinciples.Bridge;
using MyLibrary.MyDesignPrinciples.BuilderPattern;
using MyLibrary.MyDesignPrinciples.Composite;
using MyLibrary.MyDesignPrinciples.Decorator;
using MyLibrary.MyDesignPrinciples.Facade;
using MyLibrary.MyDesignPrinciples.MyPrototype;
using MyLibrary.MyDesignPrinciples.MyTemplateMethod;
using MyLibrary.MyDesignPrinciples.Strategy;
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

            Strategy();

            Bridge();

            Adapter();

            Decorator();

            Composite();

            Facade();

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

            MyTemplateClient.Run();
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

            MyBuilderPatternClient.Run();
        }

        private void Prototype()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyPrototypeClient.Run();
        }

        private void Strategy()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyStrategyClient.Run();
        }

        private void Bridge()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var implementationA = new MyImplementationA();
            var abstraction = new MyAbstraction(implementationA);
            abstraction.FeatureA();
            abstraction.FeatureB();

            var implementationB = new MyImplementationB();
            var subAbstraction = new MySubAbstraction(implementationB);
            subAbstraction.FeatureA();
            subAbstraction.FeatureB();
            subAbstraction.SubFeature();
        }

        private void Adapter()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyAdapterClient.Run();
        }

        private void Decorator()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var comp = new MyComponent("data");
            var decoratorA = new MyDecoratorA(comp);
            decoratorA.Execute();
            var decoratorB = new MyDecoratorB(comp);
            decoratorB.Execute();

            var manager = new MyManager(decoratorA);
            manager.UseComponent();
        }

        private void Composite()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var composite = new MyComposite();
            var leaf = new MyLeaf();
            var leaf2 = new MyLeaf();
            composite.Add(leaf);
            composite.Add(leaf2);
            var composite2 = new MyComposite();
            composite.Add(composite2);
            var leaf3 = new MyLeaf();
            var leaf4 = new MyLeaf();
            composite2.Add(leaf3);
            composite2.Add(leaf4);
            composite2.Remove(leaf4);

            composite.Execute();

            var children = composite.GetChildren();
            Console.WriteLine("children: ");
            foreach (var child in children)
            {
                Console.WriteLine(child.GetType().Name);

            }
        }

        private void Facade()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            var facade = new MyFacade();

            var ab = facade.ConvenientMethodAB();
            Console.WriteLine(ab);
            var ac = facade.ConvenientMethodAC();
            Console.WriteLine(ac);

        }
    }
}
