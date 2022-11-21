using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    /// <summary>
    /// For each test, it will create a new instance of MyClassFixtureB,
    /// and pass the shared instance of MyFixtureA and MyFixtureB to the constructor.
    /// </summary>
    public class MyClassFixtureB : IClassFixture<MyFixtureA>, IClassFixture<MyFixtureB>
    {
        MyFixtureA myFixtureA;
        MyFixtureB myFixtureB;
        public MyClassFixtureB(MyFixtureA myFixtureA, MyFixtureB myFixtureB)
        {
            this.myFixtureA = myFixtureA;
            this.myFixtureB = myFixtureB;
        }

        [Fact]
        public void MyFactA()
        {
            var result = myFixtureA.Data
                + myFixtureB.Data
                + nameof(MyFactA);

            Assert.Equal(
                nameof(MyFixtureA) + nameof(MyFixtureA.Data) +
                nameof(MyFixtureB) + nameof(MyFixtureB.Data) +
                nameof(MyFactA),
                result);
        }

        [Fact]
        public void MyFactB()
        {
            var result = myFixtureA.Data
                + myFixtureB.Data
                + nameof(MyFactB);

            Assert.Equal(
                nameof(MyFixtureA) + nameof(MyFixtureA.Data) +
                nameof(MyFixtureB) + nameof(MyFixtureB.Data) +
                nameof(MyFactB),
                result);
        }
    }
}
