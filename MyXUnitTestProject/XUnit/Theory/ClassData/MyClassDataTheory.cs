namespace MyXUnitTestProject
{
    public class MyClassDataTheory
    {
        [Theory]
        [ClassData(typeof(MyDataClassA))]
        public void MyTheory_ClassDataA(double assert, string actual)
        {
            Assert.Equal(assert.ToString() + "A", actual);
        }
        [Theory]
        [ClassData(typeof(MyDataClassB))]
        public void MyTheory_ClassDataB(double assert, string actual)
        {
            Assert.Equal(assert.ToString() + "B", actual);
        }
        [Theory]
        [ClassData(typeof(MyDataClassA))]
        [ClassData(typeof(MyDataClassB))]
        public void MyTheory_ClassDataAB(double assert, string actual)
        {
            string a = assert.ToString() + "A";
            string b = assert.ToString() + "B";
            bool check = actual.Equals(a) || actual.Equals(b);
            Assert.True(check);
        }
    }
}
