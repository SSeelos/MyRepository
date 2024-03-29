﻿using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Proxy
{
    public interface IService
    {
        void Operation();
        void Operation(MyPlainOldObject data);
    }
    class MyService : IService
    {
        public void Operation()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());
        }

        public void Operation(MyPlainOldObject data)
        {
            Console.WriteLine(data.MyPropertyA + ", " + data.MyPropertyB);
        }
    }
}
