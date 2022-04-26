using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Proxy
{
    /// <summary>
    /// The Proxy has an interface identical to the "real" Service.
    /// 
    /// Applications:
    /// lazy loading,caching, controlling the access, logging, ... 
    /// A Proxy then, depending on the result, 
    /// passes the execution to the same method in a linked RealSubject object.
    /// </summary>
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
