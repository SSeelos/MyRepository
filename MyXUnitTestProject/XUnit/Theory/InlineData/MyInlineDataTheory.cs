namespace MyXUnitTestProject
{
    public class MyInlineDataTheory
    {
        [Theory]
        [InlineData(1, 2)]
        public void MyTheory_InlineDataA(double a, double b)
        {
            Assert.True(a == 1 && b == 2);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void MyTheory_InlineDataB(double a)
        {
            Assert.True(a == 1 || a == 2);
        }
    }
}
