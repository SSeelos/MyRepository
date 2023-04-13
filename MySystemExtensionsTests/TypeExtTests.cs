using FluentAssertions;
using MySystemExtensions;

namespace MySystemExtensionsTests;

public class TypeExtTests
{
    [Fact]
    public void Test1()
    {
        this.GetType().Display()
            .Should().Be(nameof(TypeExtTests));
    }
}