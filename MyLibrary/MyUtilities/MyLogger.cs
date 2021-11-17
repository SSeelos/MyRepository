using System;
using System.Reflection;
using System.Threading;

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

        void ThreadLog(Thread thread);
    }
    public class MyConsoleLogger : ILogger
    {
        private static MyConsoleLogger instance;
        public static MyConsoleLogger Instance => GetInstance();

        private static string ClassPrefix = " - CLASS - ";
        private static string MethodPrefix = " - METHOD - ";
        private static string ThreadPrefix = " - Thread: ";

        private MyConsoleLogger()
        { }

        private static MyConsoleLogger GetInstance()
        {
            return instance ?? new MyConsoleLogger();
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

            Console.WriteLine(ClassPrefix + classType.Name + " ");
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
            Console.WriteLine(ClassPrefix + classType.Name + MethodPrefix + method.Name);
        }

        public void MethodLog(MethodBase method, Hirarchy hirarchy = Hirarchy.Line)
        {
            switch (hirarchy)
            {
                case Hirarchy.Title:
                    Console.WriteLine();
                    Console.WriteLine(MethodPrefix + method.Name + " ");
                    Console.WriteLine();
                    break;
                case Hirarchy.Line:
                    Console.WriteLine(MethodPrefix + method.Name + " ");
                    break;
                default:
                    break;
            }
        }

        public void ThreadLog(Thread thread)
        {
            Console.WriteLine(ThreadPrefix + "Name: {0}, State: {1}", thread.Name, thread.ThreadState);

        }
    }
}
