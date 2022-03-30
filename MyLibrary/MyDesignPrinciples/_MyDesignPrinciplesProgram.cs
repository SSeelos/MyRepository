
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.AbstractFactory;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Adapter;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Bridge;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Builder;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Chain;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Command;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Composite;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Decorator;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Facade;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Singleton;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.State;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Strategy;
using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.TemplateMethod;
using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples
{
    public class MyDesignPrinciplesProgram : IProgram
    {
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

            State();

            Chain();

            Command();

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
        private void State()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyStateClient.Run();

        }
        private void Chain()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyChainClient.Run();

        }
        private void Command()
        {
            MyConsoleLogger.Instance.MethodLog(MethodBase.GetCurrentMethod(), Hirarchy.Title);

            MyCommandClient.Run();

        }
    }
}
