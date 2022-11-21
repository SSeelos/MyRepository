using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    /// <summary>
    /// For each test, it will create a new instance of MyClassFixtureA,
    /// and pass the shared instance of MyFixtureA to the constructor.
    /// </summary>
    public class MyClassFixtureA : IClassFixture<MyFixtureA>
    {
        MyFixtureA myFixtureA;
        public MyClassFixtureA(MyFixtureA myFixtureA)
        {
            //2, 4
            this.myFixtureA = myFixtureA;
        }

        [Fact]
        public void MyFactA()
        {
            //3
            var result = myFixtureA.Data + nameof(MyFactA);
            Assert.Equal(nameof(MyFixtureA) + nameof(MyFixtureA.Data) + nameof(MyFactA), result);
        }

        [Fact]
        public void MyFactB()
        {
            //5
            var result = myFixtureA.Data + nameof(MyFactB);
            Assert.Equal(nameof(MyFixtureA) + nameof(MyFixtureA.Data) + nameof(MyFactB), result);
        }
    }
}
