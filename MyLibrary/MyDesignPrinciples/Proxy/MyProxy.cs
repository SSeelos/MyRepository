using MyLibrary.MyUtilities;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Proxy
{
    class MyProxy : IService
    {
        IService Service;
        public MyProxy(IService service)
        {
            this.Service = service;
        }
        public void Operation()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            Service.Operation();
        }

        public void Operation(MyPlainOldObject data)
        {

        }
    }
}
