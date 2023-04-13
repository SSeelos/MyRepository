namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Adapter
{
    class MyAdapterClient
    {
        public static void Run()
        {
            var compatibleService = new MyCompatibleService("compatible");
            var service = new MyIncompatibleService(5);
            var adapter = new MyAdapter(service);

            var receiver = new MyServiceReceiver();
            receiver.UseService(compatibleService);
            receiver.UseService(adapter);
        }
    }
}
