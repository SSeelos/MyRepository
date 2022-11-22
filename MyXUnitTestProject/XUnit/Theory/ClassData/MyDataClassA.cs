namespace MyXUnitTestProject
{
    public class MyDataClassA : _MyDataClass
    {
        public MyDataClassA()
            : base(new List<object[]>
            {
                new object[] {1,"1A"},
                new object[] {2,"2A"},
            })
        {
        }
    }
}
