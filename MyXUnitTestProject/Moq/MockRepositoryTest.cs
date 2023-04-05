using MyDotNet6ConsoleApp.DependencyInjection;
using MyDotNet6ConsoleApp.DependencyInjection.Services;

namespace MyXUnitTestProject
{
    public class MockRepositoryTest : IDisposable
    {
        private readonly MockRepository mockRepository;
        private readonly Mock<IDependencyA> mockDependencyA;
        private readonly Mock<IDependencyB> mockDependencyB;
        private readonly DependantA dependant;

        public MockRepositoryTest()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockDependencyA = mockRepository.Create<IDependencyA>();
            this.mockDependencyB = mockRepository.Create<IDependencyB>();

            this.dependant = new DependantA(mockDependencyA.Object, mockDependencyB.Object);
        }

        public void Dispose()
        {
            //avoid calling VerifyAll() in each test method
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void MockRepositoryNoSetupTest()
        {
            Action throwing = () => mockDependencyA.Object.Execute();

            throwing.Should().Throw<MockException>();
        }
        [Fact]
        public void MockRepositorySetupTest()
        {
            this.mockDependencyA.Setup(mock => mock.Execute());

            Action throwing = () => mockDependencyA.Object.Execute();

            throwing.Should().NotThrow<MockException>();
        }

        [Fact]
        public void DependantTest()
        {
            this.mockDependencyA.Setup(mock => mock.Execute());
            this.mockDependencyB.Setup(mock => mock.Execute());

            //the dependant should call both A and B
            Action happyPath = () => this.dependant.Run();
            happyPath.Should().NotThrow<MockException>();
        }
        [Fact]
        public void DependantNoSetupTest()
        {
            //should throw because of missing setups
            Action throwing = () => this.dependant.Run();
            throwing.Should().Throw<MockException>().And
                .Message.Should().Contain("All invocations on the mock must have a corresponding setup");
        }
        [Fact]
        public void UncalledSetup()
        {
            this.mockDependencyA.Setup(mock => mock.Execute());
            this.mockDependencyB.Setup(mock => mock.Execute());

            //run only A
            this.mockDependencyA.Object.Execute();

            //VerifyAll should fail because B was not called
            Action throwing = () => this.mockRepository.VerifyAll();
            throwing.Should().Throw<MockException>().And
                .Message.Should().Contain("The mock repository failed verification");

            //execute B to satisfy validation on dispose
            this.mockDependencyB.Object.Execute();
        }
    }
}
