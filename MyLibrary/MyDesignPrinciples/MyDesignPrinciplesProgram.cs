
using MyLibrary.MyDesignPrinciples.AbstractFactory;
using MyLibrary.MyDesignPrinciples.Adapter;
using MyLibrary.MyDesignPrinciples.Bridge;
using MyLibrary.MyDesignPrinciples.BuilderPattern;
using MyLibrary.MyDesignPrinciples.Composite;
using MyLibrary.MyDesignPrinciples.Decorator;
using MyLibrary.MyDesignPrinciples.Facade;
using MyLibrary.MyDesignPrinciples.FactoryMethod;
using MyLibrary.MyDesignPrinciples.MyPrototype;
using MyLibrary.MyDesignPrinciples.MyTemplateMethod;
using MyLibrary.MyDesignPrinciples.Strategy;
using MyLibrary.MyUtilities;
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

            MyFactoryMethodClient.Run();

        }

        public void AbstractFactory()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyAbstractFactoryClient.Run();
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

            MyBridgeClient.Run();
        }

        private void Adapter()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyAdapterClient.Run();
        }

        private void Decorator()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyDecoratorClient.Run();
        }

        private void Composite()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyCompositeClient.Run();
        }

        private void Facade()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyFacadeClient.Run();

        }
    }
}
