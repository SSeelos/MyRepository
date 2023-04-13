using Autofac;
using Autofac.Extras.Moq;
using MyDotNet6ConsoleApp.DependencyInjection;
using MyDotNet6ConsoleApp.DependencyInjection.Services;
using NUnit.Framework;

namespace MyNUnitTestProject.DependencyInjection
{
    internal class DependantTest
    {
        [Test]
        public void MockBehaviour()
        {

            using (var mock = AutoMock.GetLoose())
            {
                var dependant = mock.Create<Dependant>();

                dependant.Run();

                Assert.NotNull(dependant);
            }

        }
        [Test]
        public void ConfigureMock()
        {

            using (var mock = AutoMock.GetLoose())
            {
                //do some config
                mock.Mock<IDependencyA>().Setup(dependency => dependency.Execute());
                var dependant = mock.Create<Dependant>();
                dependant.Run();

                mock.Mock<IDependencyA>().Verify(dependency => dependency.Execute());
                Assert.NotNull(dependant);
            }

        }
        [Test]
        public void ConfigureDependencies()
        {
            var dependency = new DependencyA();
            using (var mock = AutoMock.GetLoose(builder => builder.RegisterInstance(dependency).As<IDependencyA>()))
            {
                var mockDependency = mock.Create<IDependencyA>();

                //depends on IDependencyA, autofac will inject the registered instance
                var dependant = mock.Create<Dependant>();
                dependant.Run();

                Assert.NotNull(dependant);
            };

        }
    }
}
