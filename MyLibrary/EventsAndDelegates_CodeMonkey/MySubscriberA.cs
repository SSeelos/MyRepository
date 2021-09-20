﻿using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.EventsAndDelegates_CodeMonkey
{
    public interface ISubscriber
    {
        void Subscribe(MyPublisher publisher);
    }
    public class MySubscriberA : ISubscriber
    {
        public static string suffix = "A";
        public void Subscribe(MyPublisher publisher)
        {
            publisher.OnEventTriggered += Publisher_OnEventTriggered;
            publisher.OnEventArgsTriggered += Publisher_OnEventArgsTriggered;
            publisher.OnActionTriggered += Publisher_OnActionTriggered;
            publisher.OnFuncTriggered += Publisher_OnFuncTriggered;
            publisher.OnFuncParamTriggered += Publisher_OnFuncParamTriggered;
            publisher.OnEventDelegateTriggered += Publisher_OnEventDelegateTriggered;
        }

        private string Publisher_OnFuncParamTriggered(string arg)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            arg += " " + suffix;
            Console.WriteLine(arg);

            return arg;
        }
        private string Publisher_OnFuncTriggered()
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            return "Func return " + suffix;
        }

        private void Publisher_OnEventDelegateTriggered(string param)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(param + "" + suffix);
        }


        private void Publisher_OnActionTriggered(string arg1, string arg2)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(arg1 + " " + arg2 + " " + suffix);
        }

        private void Publisher_OnEventArgsTriggered(object sender, string e)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(sender + " " + e + suffix);


        }

        public void Publisher_OnEventTriggered(object sender, EventArgs e)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(sender + " " + e);
        }
    }
}
