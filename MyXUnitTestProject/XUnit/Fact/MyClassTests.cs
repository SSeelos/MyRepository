namespace MyXUnitTestProject.XUnit
{
    public class MyClassTests : IDisposable
    {
        string? _data;
        //(optional) setup
        public MyClassTests()
        {
            //1, 4
            _data = "data";
        }
        //(optional) teardown
        public void Dispose()
        {
            //3, 6
            _data = null;
        }

        [Fact]
        public void MyFactA()
        {
            //5
            _data += nameof(MyFactA);
            Assert.Equal("dataMyFactA", _data);
        }

        [Fact]
        public void MyFactB()
        {
            //2
            _data += nameof(MyFactB);

            Assert.Equal("dataMyFactB", _data);
        }

    }
}
