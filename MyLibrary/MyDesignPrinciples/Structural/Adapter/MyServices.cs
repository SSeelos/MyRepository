using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Adapter
{

    public class MyIncompatibleService
    {
        private double field;
        public MyIncompatibleService(double field)
        {
            this.field = field;
        }
        public double IncompatibleServiceMethod()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return field;
        }
    }
    public class MyCompatibleService : IClientInterface
    {
        private string field;
        public MyCompatibleService(string field)
        {
            this.field = field;
        }
        public string CompatibleMethod()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return field;
        }
    }
}
