using System;
using Xunit;
using  TestCalculator;
namespace XUnitTestCalculator
{
    public class XUnitTest
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(Double.NaN, Double.NaN, Double.NaN)]
        [InlineData(1.2,2.3,3.5)]
        public void TestAddition(double first, double second, double result)
        {
            double calcResult;
            calcResult = Program.Addition(first, second);
            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(Double.NaN, Double.NaN, Double.NaN)]
        [InlineData(10.5, 2.3, 8.2)]
        public void TestSubtraction(double first, double second, double result)
        {
            double calcResult;
            calcResult = Program.Subtraction(first, second);
            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(1, 2, 2)]
        [InlineData(Double.NaN, Double.NaN, Double.NaN)]
        [InlineData(10.5, 10, 105)]
        public void TestMulti(double first, double second, double result)
        {
            double calcResult;
            calcResult = Program.Multiplication(first, second);
            Assert.Equal(result, calcResult);
        }

        [Theory]
        [InlineData(4, 4, 1)]
        [InlineData(Double.NaN, Double.NaN, Double.NaN)]
        [InlineData(100.1, 10 , 10.01)]
        public void TestDiv(double first, double second, double result)
        {
            double calcResult;
            calcResult = Program.Division(first, second);
            Assert.Equal(result, calcResult);
        }


        [Fact]
        public void TestDivThrowsDivideByZero()
        {
            double firstArgument = 7;
            double secundArgument = 0;
            Assert.Throws<DivideByZeroException>(() => Program.Division(firstArgument, secundArgument));

        }
        
        [Fact]
        public void TestSubtraktionArray2()
        {
            double expektedResult = 30;
            double[] numbers = { 10,-20 };
            double calculatedResult = Program.Subtraction(numbers);
            Assert.Equal(expektedResult, calculatedResult);
        }
        [Fact]
        public void TestSubtraktionArray()
        {
            double expektedResult = -60.6;
            double[] numbers = { -2.2, 5.5, - 8.2, 61.1 }; 
            double calculatedResult = Program.Subtraction(numbers);

            Assert.Equal(expektedResult, calculatedResult);
        }


    }
}
