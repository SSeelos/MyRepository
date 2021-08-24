using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Proxy
{
    class MyProxyClient
    {
        public static void Run()
        {
            var proxy = new MyProxy();
            var service = new MyService();

            UseService(proxy);
            UseService(service);
        }
        private static void UseService(IService service)
        {
            service.Operation();
        }
    }
}
