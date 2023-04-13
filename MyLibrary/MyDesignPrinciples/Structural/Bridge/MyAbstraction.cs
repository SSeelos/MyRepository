using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Bridge
{
    public class MyAbstraction
    {
        protected IImplementation implementation;

        public MyAbstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public void FeatureA()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            implementation.MethodA();
        }
        public void FeatureB()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            implementation.MethodB();
        }

    }

    public class MySubAbstraction : MyAbstraction
    {
        public MySubAbstraction(IImplementation implementation) : base(implementation)
        {
        }
        public void SubFeature()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            implementation.MethodA();
        }
    }
}
