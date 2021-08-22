using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Adapter
{
    class MyAdapterClient
    {
        internal void Run()
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
