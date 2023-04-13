
using Xunit.Abstractions;

namespace MyXUnitTestProject.XUnit
{
    public class MyClassFixtureSelf : IClassFixture<MyClassFixtureSelf>
    {
        private readonly ITestOutputHelper _output;
        public string Data { get; private set; }
        public MyClassFixtureSelf(ITestOutputHelper output)
        {
            _output = output;
            Data = nameof(Data);
        }
    }

    public class MyClassFixture : IClassFixture<MyClassFixtureSelf>
    {
        MyClassFixtureSelf fixture;
        public MyClassFixture(MyClassFixtureSelf fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void Fact()
        {
            fixture.Data.Should().Be(nameof(fixture.Data));
        }
    }
}
