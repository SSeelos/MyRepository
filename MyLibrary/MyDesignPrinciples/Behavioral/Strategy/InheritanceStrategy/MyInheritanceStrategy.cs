using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Strategy
{
    public class MyInheritanceStrategy : IInheritanceStrategy
    {
        public void Execute(string data)
        {
            data += " Inheritance";
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(data);
        }
    }
}
