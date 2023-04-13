using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    [Collection(nameof(MyCollectionFixtures))]
    public class MyCollectionTestsC : IClassFixture<MyFixtureC>
    {
        MyFixtureA myFixtureA;
        MyFixtureB myFixtureB;
        MyFixtureC myFixtureC;
        public MyCollectionTestsC(MyFixtureA myFixtureA, MyFixtureB myFixtureB, MyFixtureC myFixtureC)
        {
            this.myFixtureA = myFixtureA;
            this.myFixtureB = myFixtureB;
            this.myFixtureC = myFixtureC;
        }

        [Fact]
        public void MyFactA()
        {
            Assert.Equal(nameof(MyFixtureA) + nameof(MyFixtureA.Data), myFixtureA.Data);
            Assert.Equal(nameof(MyFixtureB) + nameof(MyFixtureB.Data), myFixtureB.Data);
            Assert.Equal(nameof(MyFixtureC) + nameof(MyFixtureC.Data), myFixtureC.Data);
        }
        [Fact]
        public void MyFactB()
        {
            Assert.Equal(nameof(MyFixtureC) + nameof(MyFixtureC.Data), myFixtureC.Data);
        }
    }
}
