using MyLibrary.MyUtilities;

namespace MyLibrary.MyDesignPrinciples.Proxy
{
    class MyProxyClient
    {
        public static void Run()
        {
            var service = new MyService();
            var proxy = new MyProxy(service);


            var manager = new MyManager(proxy);
            manager.UseService_Operation();

            var data = new MyPlainOldObject()
            {
                MyPropertyA = "A",
                MyPropertyB = "B"
            };
            manager.UseService_Data(data);

        }
    }
    class MyManager
    {
        protected IService Service;
        public MyManager(IService service)
        {
            this.Service = service;
        }
        public void UseService_Operation()
        {
            Service.Operation();
        }
        public void UseService_Data(MyPlainOldObject data)
        {
            Service.Operation(data);
        }

    }
}
