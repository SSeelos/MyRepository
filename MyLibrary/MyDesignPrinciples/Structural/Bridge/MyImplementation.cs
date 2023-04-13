using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Bridge
{
    public interface IImplementation
    {
        void MethodA();
        string MethodB();
    }
    public class MyImplementationA : IImplementation
    {
        private string propertyImpA;
        public void MethodA()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            
        }

        public string MethodB()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            return this.propertyImpA;
        }
    }
    public class MyImplementationB : IImplementation
    {
        private string propertyImpB;
        public void MethodA()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
        }

        public string MethodB()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            return this.propertyImpB;
        }
    }
}
