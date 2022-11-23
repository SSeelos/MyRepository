using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    /// <summary>
    /// For each test, it will create a new instance of MyClassFixtureB,
    /// and pass the shared instance of MyFixtureA and MyFixtureB to the constructor.
    /// </summary>
    public class MyClassFixtureC : IClassFixture<MyFixtureC>
    {
        MyFixtureC myFixture;
        public MyClassFixtureC(MyFixtureC myFixture)
        {
            this.myFixture = myFixture;
        }

        [Fact]
        public void MyFactA()
        {
            var result = myFixture.Data
                + myFixture.DataC
                + nameof(MyFactA);

            Assert.Equal(
                nameof(MyFixtureC) + nameof(myFixture.Data) +
                nameof(MyFixtureC) + nameof(myFixture.DataC) +
                nameof(MyFactA),
                result);
        }
    }
}
