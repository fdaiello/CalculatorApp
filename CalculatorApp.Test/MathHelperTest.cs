using System;
using Xunit;

namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void TestIsEven()
        {
            var cal = new MathFormulas();

            int x = 1;
            int y = 2;

            var xResult = cal.IsEven(x);
            var yResult = cal.IsEven(y);

            Assert.False(xResult);
            Assert.True(yResult);

        }
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void TestDiff(int x, int y, int result)
        {
            var calculator = new MathFormulas();
            Assert.Equal(result, calculator.Diff(y, x));
        }
        [Theory]
        [InlineData(new int[] { 5, 5 }, 10)]
        [InlineData(new int[] { 10, 10 }, 20)]
        public void TestSum(int[] values, int result)
        {
            var calculator = new MathFormulas();
            Assert.Equal(result, calculator.Sum(values));
        }
        [Theory(Skip ="not needed!")]
        [InlineData(5, 5, 10)]
        public void TestAdd(int x, int y, int result)
        {
            var calculator = new MathFormulas();
            Assert.Equal(result, calculator.Add(x, y));
        }
        [Theory]
        [InlineData(new int[] { 10, 20, 30 }, 20)]
        public void TestAverage(int[] values, double result)
        {
            var calculator = new MathFormulas();
            Assert.Equal(result, calculator.Average(values));
        }
    }
}
