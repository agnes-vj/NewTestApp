
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
        [TestCase(Point.NORTH, Direction.RIGHT, Point.EAST, TestName = "Test Roatate: North, right => EAST")]
        [TestCase(Point.NORTH, Direction.LEFT, Point.WEST, TestName = "Test Roatate: North, left => WEST")]
        [TestCase(Point.EAST, Direction.RIGHT, Point.SOUTH, TestName = "Test Roatate: East, right => SOUTH")]
        [TestCase(Point.EAST, Direction.LEFT, Point.NORTH, TestName = "Test Roatate: East, left => NORTH")]
        [TestCase(Point.SOUTH, Direction.RIGHT, Point.WEST, TestName = "Test Roatate: South, right => WEST")]
        [TestCase(Point.SOUTH, Direction.LEFT, Point.EAST, TestName = "Test Roatate: South, left => EAST")]
        [TestCase(Point.WEST, Direction.RIGHT, Point.NORTH, TestName = "Test Roatate: West, right => NORTH")]
        [TestCase(Point.WEST, Direction.LEFT, Point.SOUTH, TestName = "Test Roatate: West, left => SOUTH")]


        [Description(" returns EAST when passed NORTH and RIGHT")]
        public void TestRotate(Point inputPoint, Direction inputDirection, Point expectedResult)
        {
            //Arrange
            Compass compass = new Compass();

            //Act
            Point result = compass.Rotate(inputPoint, inputDirection);

            //Assert
            result.Should().Be(expectedResult);

            Assert.Multiple(() =>
            {
                Assert.That(expectedResult , Is.EqualTo(result));
            });
        }
       


    }
}