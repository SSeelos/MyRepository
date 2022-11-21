namespace MyDotNet6ConsoleApp.Threading
{
    public class MyTaskExample : IThreadingExample
    {
        public void Execute()
        {
            Action action = () =>
            {
                Console.WriteLine(
                    $"{nameof(Task)}: +{Task.CurrentId}, " +
                    $"{nameof(Thread)}: {Environment.CurrentManagedThreadId}");
            };

            var taskA = new Task(action);

            Task taskB = Task.Factory.StartNew(action);
            //block thread
            taskB.Wait();

            taskA.Start();
            Console.WriteLine(
                $"{nameof(Task)}.{nameof(Task.Id)}:{taskA.Id}, " +
                $"{nameof(Thread)}: {Environment.CurrentManagedThreadId}");
            taskA.Wait();

            Task taskC = Task.Run(() =>
            {
                Console.WriteLine(
                $"{nameof(Task)}.{nameof(Task.CurrentId)}: {Task.CurrentId}, " +
                $"{nameof(Thread)}: {Environment.CurrentManagedThreadId}");
            });
            taskC.Wait();

            Task taskD = new Task(action);
            taskD.RunSynchronously();
            //its good practice to wait even if run synchronously
            taskD.Wait();
        }
    }
}
