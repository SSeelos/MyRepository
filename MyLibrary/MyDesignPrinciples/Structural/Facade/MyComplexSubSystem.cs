using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Facade
{
    public class MyComplexSubSystem
    {
        public class MySubsystemClassA
        {
            private string data = "dataA";
            public string Method()
            {
                MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

                return data;
            }
        }
        public class MySubsystemClassB
        {
            private string data = "dataB";
            public string Method()
            {
                MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

                return data;
            }
        }
        public class MySubsystemClassC
        {
            private string data = "dataC";
            public string Method()
            {
                MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

                return data;
            }
        }
    }
}
