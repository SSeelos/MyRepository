namespace MyXUnitTestProject
{
    public class MyDataClassB : _MyDataClass
    {
        public MyDataClassB()
            : base(new List<object[]>
            {
                new object[] {1,"1B"},
                new object[] {2,"2B"},
            })
        {
        }
    }
}
