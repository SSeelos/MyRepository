using System;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Facade
{
    class MyFacadeClient
    {
        public static void Run()
        {
            var facade = new MyFacade();

            var ab = facade.ConvenientMethodAB();
            Console.WriteLine(ab);
            var ac = facade.ConvenientMethodAC();
            Console.WriteLine(ac);
        }
    }
}
