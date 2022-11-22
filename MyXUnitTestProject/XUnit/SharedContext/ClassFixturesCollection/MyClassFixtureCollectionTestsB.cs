using MyXUnitTestProject.XUnit.SharedContext;

namespace MyXUnitTestProject.XUnit
{
    [Collection(nameof(MyClassFixturesCollection))]
    public class MyClassFixtureCollectionTestsB
    {
        MyFixtureA myFixtureA;
        MyFixtureB myFixtureB;
        public MyClassFixtureCollectionTestsB(MyFixtureA myFixtureA, MyFixtureB myFixtureB)
        {
            this.myFixtureA = myFixtureA;
            this.myFixtureB = myFixtureB;
        }

        [Fact]
        public void MyFactA()
        {
            //
        }
        [Fact]
        public void MyFactB()
        {
            //
        }
    }
}
