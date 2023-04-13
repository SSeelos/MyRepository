using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    /// <summary>
    /// will never be created
    /// apply [CollectionDefinition] and all the ICollectionFixture interfaces
    /// </summary>
    [CollectionDefinition(nameof(MyCollectionFixtures))]
    public class MyCollectionFixtures :
        ICollectionFixture<MyFixtureA>,
        ICollectionFixture<MyFixtureB>
    {
    }
}
