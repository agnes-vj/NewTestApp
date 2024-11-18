
using TestApp;
using NUnit;
using FluentAssertions;
namespace TestAPP.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(Point.NORTH, Direction.LEFT, Point.SOUTH, TestName = "TestRoatate")]
        [Description(" returns EAST when passed NORTH and RIGHT")]
        public void TestRotate(Point inputPoint, Direction inputDirection, Point expectedResult)
        {
            //Arrange
            //Point point = Point.NORTH;
            //Direction direction = Direction.LEFT;
            //Point expectedResult = Point.EAST;
            Compass compass = new Compass();

            //Act
           Point result = compass.Rotate(inputPoint, inputDirection);

            //Assert
            result.Should().Be(expectedResult);  
           
        }
       


    }
}