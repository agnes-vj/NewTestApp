
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
        [Description(" returns EAST when passed NORTH and RIGHT")]

        public void TestRotateNorthToRight()
        {
          // Arrange
            Point inputPoint = Point.NORTH;
            Direction inputDirection = Direction.RIGHT;
            Compass compass = new Compass();

           //Act
           Point Result = compass.Rotate(inputPoint, inputDirection);


            //Assert

            Result.Should().Be(Point.EAST);
        }

        [Test]
       
        public void TestRotateRight()
        {
            //Arrange
            Point[] inputPoint = { Point.EAST, Point.WEST, Point.NORTH, Point.SOUTH };
            Point[] expectedOutput = { Point.SOUTH, Point.NORTH, Point.EAST, Point.WEST };
            Point[] result = new Point[4];

            Compass compass = new Compass();

            //Act
            for( int i=0; i<4; i++)
            {
               
               result[i] = compass.Rotate(inputPoint[i], Direction.RIGHT);
            }
      

            //Assert
            //result.Should().Be(expectedResult);

            Assert.Multiple(() =>
            {
                for (int i = 0; i < 4; ++i)
                {
                    Assert.That(expectedOutput[i], Is.EqualTo(result[i]));
                }
            });
        }

        [Test]
        public void TestRotateLeft()
        {
            //Arrange
            Point[] inputPoint = { Point.EAST, Point.WEST, Point.NORTH, Point.SOUTH };
            Point[] expectedOutput = { Point.NORTH, Point.SOUTH, Point.WEST, Point.EAST };
            Point[] result = new Point[4];

            Compass compass = new Compass();

            //Act
            for (int i = 0; i < 4; i++)
            {

                result[i] = compass.Rotate(inputPoint[i], Direction.LEFT);
            }


            //Assert
            //result.Should().Be(expectedResult);

            Assert.Multiple(() =>
            {
                for (int i = 0; i < 4; ++i)
                {
                    Assert.That(expectedOutput[i], Is.EqualTo(result[i]));
                }
            });
        }


       

    }
    public class TestStringManipulator
    {

        [Test]
        [TestCase("Hello", "olleH", Description = "For Hello, Reverse String Returns olleH ?")]
        [TestCase("", "", Description = "For empty string, Reverse String Returns empty string ?")]
        [TestCase("**Hello!", "!olleH**", TestName = "For Hello, Reverse String Returns olleH ?")]
        //      [TestCase(null, "Input can not be null", "For null, Reverse String Returns error message ?")]
        public void TestReverseString(string inputString, string expectedResult)
        {
            //Arrange
 
            StringManipulator stringManipulator = new StringManipulator();
            string result;

            //Assign
            result = stringManipulator.ReverseString(inputString);


            //Assert

            result.Should().Be(expectedResult);
        }
        [Test]
        [TestCase("madam", true, TestName = "madam is a Palindrom? true")]
        [TestCase("Miss You!", false, TestName = "Miss You! is a Palindrom? false")]

        public void TestIsPalindrome(string inputString, bool isPalindrome)
        {
            //Arrage
            StringManipulator stringManipulator = new StringManipulator();
            bool result;

            //Assign
            result = stringManipulator.IsPalindrome(inputString);

            //Assert

            result.Should().Be(isPalindrome);





        }

    }
}