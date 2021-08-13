using System;
using System.Reflection;

namespace MyLibrary.MyUtilities
{
    public enum Hirarchy
    {
        Title,
        Line
    }
    public interface ILogger
    {
        void ClassLog(Type classType, Hirarchy hirarchy = Hirarchy.Line);
        void MethodLog(MethodBase method, Hirarchy hirarchy = Hirarchy.Line);
        void ClassMethodLog(Type classType, MethodBase method, Hirarchy hirarchy = Hirarchy.Line);
    }
    public class MyConsoleLogger : ILogger
    {
        private static MyConsoleLogger instance;
        public static MyConsoleLogger Instance => GetInstance();

        private MyConsoleLogger() { }

        private static MyConsoleLogger GetInstance()
        {
            return instance != null ? instance : new MyConsoleLogger();
        }
        public void ClassLog(Type classType, Hirarchy hirarchy = Hirarchy.Line)
        {
            switch (hirarchy)
            {
                case Hirarchy.Title:
                    Console.WriteLine();
                    break;
                case Hirarchy.Line:
                    break;
                default:
                    break;

            }

            Console.WriteLine(classType.GetType().Name + " ");
            Console.WriteLine();
        }

        public void ClassMethodLog(Type classType, MethodBase method, Hirarchy hirarchy = Hirarchy.Line)
        {
            switch (hirarchy)
            {
                case Hirarchy.Title:
                    Console.WriteLine();
                    break;
                case Hirarchy.Line:
                    break;
                default:
                    break;
            }
            Console.WriteLine(classType.GetType().Name + ": " + method.Name);
            Console.WriteLine();
        }

        public void MethodLog(MethodBase method, Hirarchy hirarchy = Hirarchy.Line)
        {
            switch (hirarchy)
            {
                case Hirarchy.Title:
                    Console.WriteLine();
                    Console.WriteLine(method.Name + " ");
                    Console.WriteLine();
                    break;
                case Hirarchy.Line:
                    Console.WriteLine(method.Name + " ");
                    break;
                default:
                    break;
            }
        }
    }
}
