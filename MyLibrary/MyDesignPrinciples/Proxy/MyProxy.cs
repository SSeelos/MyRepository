using MyLibrary.MyUtilities;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Proxy
{
    class MyProxy : IService
    {
        IService Service;
        bool canAccess = true;
        public MyProxy(IService service)
        {
            this.Service = service;
        }
        public void Operation()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            //lazy initialization
            Service = new MyService();
            Service.Operation();
        }

        public void Operation(MyPlainOldObject data)
        {
            //access control
            if (canAccess)
                Service.Operation(data);
        }
    }
}
