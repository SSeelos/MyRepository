namespace MyXUnitTestProject.XUnit.SharedContext;

/// <summary>
/// Just before the first test in MyClassFixtureTests is run,
/// xUnit.net will create an instance of MyFixtureA
/// (fixtures cannot take dependencies on other fixtures)
/// </summary>
public class MyFixtureA : IDisposable
{
    public string? Data { get; private set; }
    public MyFixtureA()
    {
        Data = this.GetType().Name + nameof(Data);
    }
    public void Dispose()
    {
        Data = null;
    }
}

public class MyFixtureB : IDisposable
{
    public string? Data { get; private set; }
    public MyFixtureB()
    {
        Data = this.GetType().Name + nameof(Data);
    }
    public void Dispose()
    {
        Data = null;
    }
}

//inheritance works (is it best practice tho?)
public class MyFixtureC : MyFixtureA, IDisposable
{
    public string? DataC { get; private set; }
    public MyFixtureC()
    {
        DataC = this.GetType().Name + nameof(DataC);
    }
    public new void Dispose()
    {
        base.Dispose();
        DataC = null;
    }
}
