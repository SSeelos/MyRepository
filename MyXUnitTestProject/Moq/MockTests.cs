using MyConsoleAppProject;
using MyDotNet6ConsoleApp.DependencyInjection;
using MyDotNet6ConsoleApp.DependencyInjection.Services;

namespace MyXUnitTestProject
{
    public class MockTests
    {
        [Fact]
        public void MockSetupReturnTest()
        {
            var mockObj = new Mock<IMyIntefaceReturn>();
            mockObj.Setup(mock => mock.MyIntefaceReturnMethod())
            .Returns("data");

            mockObj.Object.MyIntefaceReturnMethod()
                .Should().Be("data");
        }
        [Fact]
        public void MockVerifyTest()
        {
            var mockObj = new Mock<IDependencyA>();
            mockObj.Setup(mock => mock.Execute());

            var dependant = new Dependant(mockObj.Object);
            //the dependant calls execute on the mocked dependency
            dependant.Run();

            mockObj.Verify(mock => mock.Execute(), Times.Once());
        }

        [Fact]
        public void MockBehaviorLoseTest()
        {
            //loose does not verify that methods are setup
            var mockObj = new Mock<IDependencyA>(MockBehavior.Loose);

            Action throwing = () => mockObj.Object.Execute();

            throwing.Should().NotThrow<MockException>();
        }
        [Fact]
        public void MockBehaviorStrictTest()
        {
            //strict throws exception if methods are not setup
            var mockObj = new Mock<IDependencyA>(MockBehavior.Strict);

            Action throwing = () => mockObj.Object.Execute();

            throwing.Should().Throw<MockException>().And
                .Message.Should().Be(
                "IDependencyA.Execute() invocation failed with mock behavior Strict.\n" +
                "All invocations on the mock must have a corresponding setup.");
        }
    }
}
