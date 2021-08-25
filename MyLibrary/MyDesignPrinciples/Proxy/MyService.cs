using MyLibrary.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Proxy
{
    public interface IService
    {
        void Operation();
    }
    class MyService : IService
    {
        public void Operation()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
        }
    }
}
