using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    [Collection(nameof(MyCollectionFixtures))]
    public class MyCollectionTestsB
    {
        MyFixtureA myFixtureA;
        MyFixtureB myFixtureB;
        public MyCollectionTestsB(MyFixtureA myFixtureA, MyFixtureB myFixtureB)
        {
            this.myFixtureA = myFixtureA;
            this.myFixtureB = myFixtureB;
        }

        [Fact]
        public void MyFactA()
        {
            Assert.Equal(nameof(MyFixtureA) + nameof(MyFixtureA.Data), myFixtureA.Data);
            Assert.Equal(nameof(MyFixtureB) + nameof(MyFixtureB.Data), myFixtureB.Data);
        }
        [Fact]
        public void MyFactB()
        {
            Assert.Equal(nameof(MyFixtureA) + nameof(MyFixtureA.Data), myFixtureA.Data);
            Assert.Equal(nameof(MyFixtureB) + nameof(MyFixtureB.Data), myFixtureB.Data);
        }
    }
}
