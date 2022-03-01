using Chapter4_TestUnit;
using Xunit;

namespace CalcLibUnitTest
{
    public class CalcUnitTests
    {
        [Fact]
        public void TestAdding2and2()
        {
            //arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            Calculator calc = new();

            //act
            double actual = calc.AddDouble(a, b);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2and3()
        {
            //arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            Calculator calc = new();

            //act
            double actual = calc.AddDouble(a, b);

            //assert
            Assert.Equal(expected, actual);
            //Assert.InRange(actual, 1, 15);//low-high
        }

    }
}