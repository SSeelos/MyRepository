using MyConsoleAppProject;

namespace MyXUnitTestProject.XUnit
{
    public class MyClassTests
    {
        [Fact]
        public void MyFactA()
        {
            //Arrange
            var myClass = new MyClass();

            //Act
            myClass.Max = 10;
            myClass.MyClampedValue = 11;

            //Assert
            Assert.Equal(10, myClass.MyClampedValue);
        }
        [Fact]
        public void MyFactB()
        {
            //Arrange
            var myClass = new MyClass();

            //Act
            myClass.Min = -10;
            myClass.MyClampedValue = -30;

            //Assert
            Assert.Equal(-10, myClass.MyClampedValue);
        }
    }
}
