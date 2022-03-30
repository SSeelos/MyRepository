using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Adapter
{
    public interface IClientInterface
    {
        string CompatibleMethod();
    }
    public class MyAdapter : IClientInterface
    {
        private MyIncompatibleService service;

        public MyAdapter(MyIncompatibleService service)
        {
            this.service = service;
        }

        public new string CompatibleMethod()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return service.IncompatibleServiceMethod().ToString();
        }
    }
    public class MyServiceReceiver
    {
        public void UseService(IClientInterface service)
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            Console.WriteLine(service.CompatibleMethod());
        }
    }
}
