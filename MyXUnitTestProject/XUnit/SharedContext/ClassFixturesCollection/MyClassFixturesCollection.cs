using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    [CollectionDefinition(nameof(MyClassFixturesCollection))]
    public class MyClassFixturesCollection :
        IClassFixture<MyFixtureA>,
        IClassFixture<MyFixtureB>
    {
    }
}
