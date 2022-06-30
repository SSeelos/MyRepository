namespace MyDotNet6ConsoleApp.Threading
{
    internal class ThreadLocalExample : IThreadingExample
    {
        public void Execute()
        {
            ThreadLocal<string> threadName = new ThreadLocal<string>(
                () =>
                {
                    return $"Curren Thread: {Thread.CurrentThread.ManagedThreadId}";
                }
                );

            Action action = () =>
            {
                bool repeat = threadName.IsValueCreated;
                WriteLine($"{threadName.Value} repeat:{repeat}");
            };

            Parallel.Invoke(action, action, action, action, action, action, action, action, action, action,
                action, action, action, action, action, action, action, action, action, action,
                action, action, action, action, action, action, action, action, action, action,
                action, action, action, action, action, action, action, action, action, action);

            threadName.Dispose();
        }
    }
}
