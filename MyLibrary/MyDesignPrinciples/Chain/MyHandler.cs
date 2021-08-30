using MyLibrary.MyUtilities;
using System;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Chain
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Execute(string request);
    }
    public abstract class AMyHandler : IHandler
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
    public class MyHandlerA : AMyHandler
    {
        public void Execute(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());


            if (CanHandleRequest(request))
                HandleRequest(request);
            else base.Execute(request);
        }
        private bool CanHandleRequest(string request)
        {
            return false;
        }
        private void HandleRequest(string request)
        {
            //...
        }
    }
    public class MyHandlerB : AMyHandler
    {
        public void Execute(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            if (CanHandleRequest(request))
                HandleRequest(request);
            else base.Execute(request);
        }
        private bool CanHandleRequest(string request)
        {
            return false;
        }
        private void HandleRequest(string request)
        {
            //...
        }
    }
    public class MyHandlerC : AMyHandler
    {
        public void Execute(string request)
        {
            MyConsoleLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

            if (CanHandleRequest(request))
                HandleRequest(request);
            else base.Execute(request);

        }
        private bool CanHandleRequest(string request)
        {
            return true;
        }
        private void HandleRequest(string request)
        {
            Console.WriteLine(request);
        }
    }
}
