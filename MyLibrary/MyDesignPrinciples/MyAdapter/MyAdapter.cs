using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples
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
    public class MyCompatibleService:IClientInterface
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
    public class MyServiceReceiver
    {
        public void UseService(IClientInterface service)
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            Console.WriteLine(service.CompatibleMethod());
        }
    }
}
