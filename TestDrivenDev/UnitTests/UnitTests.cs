using System;
using Xunit;
namespace UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void TestCalculatorAdd()
        {
            var myCalc = new Classes.Calculator();
            Assert.Equal(10, myCalc.Add(5,5));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void TestCalculatorIsOdd(int value)
        {
            var myCalc = new Classes.Calculator();
            Assert.True(myCalc.isOdd(value));
        }
    }

}