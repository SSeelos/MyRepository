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
            TemplateMethodProgram();

            FactoryMethod();
        }

        public void TemplateMethodProgram()
        {
            Console.WriteLine();
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            Console.WriteLine();

            var defaultClass = new DefaultClass();
            defaultClass.TemplateMethod1();
            defaultClass.TemplateMethod2();

            var concreteCLass = new ConcreteClass();
            concreteCLass.TemplateMethod1();
        }

        public void FactoryMethod()
        {
            Console.WriteLine();
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            Console.WriteLine();

            var creatorDef = new MyCreatorDefault();
            creatorDef.Operation();

            var creatorA = new MyCreatorA();
            creatorA.Operation();

            var creatorB = new MyCreatorB();
            creatorB.Operation();


        }
    }

}
