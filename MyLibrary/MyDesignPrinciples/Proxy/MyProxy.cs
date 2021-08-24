using MyLibrary.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Proxy
{
    class MyProxy : IService
    {
        public void Operation()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
        }
    }
}
