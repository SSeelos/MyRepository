using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Chain
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Execute(string request);
    }
    public abstract class _MyHandler : IHandler
    {
        protected IHandler next;
        public void Execute(string request)
        {
            if (next != null)
                next.Execute(request);
        }

        public void SetNext(IHandler handler)
        {
            this.next = handler;
        }
    }
    public class MyHandlerA : _MyHandler
    {
        public void Execute(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());


            if (CanHandleRequest(request))
                HandleRequest(request);
            else
                base.Execute(request);
        }
        private bool CanHandleRequest(string request)
        {
            return false;
        }
        private void HandleRequest(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(request);
        }
    }
    public class MyHandlerB : _MyHandler
    {
        public void Execute(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            if (CanHandleRequest(request))
                HandleRequest(request);
            else
                base.Execute(request);
        }
        private bool CanHandleRequest(string request)
        {
            return false;
        }
        private void HandleRequest(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(request);
        }
    }
    public class MyHandlerC : _MyHandler
    {
        public void Execute(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            if (CanHandleRequest(request))
                HandleRequest(request);
            else
                base.Execute(request);

        }
        private bool CanHandleRequest(string request)
        {
            return true;
        }
        private void HandleRequest(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
            Console.WriteLine(request);
        }
    }
}
