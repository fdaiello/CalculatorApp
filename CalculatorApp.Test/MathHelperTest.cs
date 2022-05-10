using System;
using Xunit;

namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void TestIsEven ()
        {
            var cal = new MathFormulas();

            int x = 1;
            int y = 2;

            var xResult = cal.IsEven(x);
            var yResult = cal.IsEven(y);

            Assert.False(xResult);
            Assert.True(yResult);

        }
    }
}
