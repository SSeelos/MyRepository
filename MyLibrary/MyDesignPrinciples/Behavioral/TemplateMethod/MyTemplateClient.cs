using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.TemplateMethod
{
    class MyTemplateClient
    {
        public static void Run()
        {
            var defaultClass = new DefaultClass();
            defaultClass.TemplateMethod1();
            defaultClass.TemplateMethod2();

            var concreteCLass = new ConcreteClass();
            concreteCLass.TemplateMethod1();
        }
    }
}
