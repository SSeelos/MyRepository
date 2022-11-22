namespace MyXUnitTestProject.XUnit.SharedContext
{
    /// <summary>
    /// Just before the first test in MyClassFixtureTests is run,
    /// xUnit.net will create an instance of MyFixtureA
    /// </summary>
    public class MyFixtureA : IDisposable
    {
        public string? Data { get; private set; }
        public MyFixtureA()
        {
            Data = nameof(MyFixtureA) + nameof(Data);
        }
        public void Dispose()
        {
            Data = null;
        }
    }
    /// </summary>
    public class MyFixtureB : IDisposable
    {
        public string? Data { get; private set; }
        public MyFixtureB()
        {
            Data = nameof(MyFixtureB) + nameof(Data);
        }
        public void Dispose()
        {
            Data = null;
        }
    }
}
