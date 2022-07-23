using System;
using Xunit;
namespace UnitTest
{
    public class UnitTest
    {
        Classes.Calculator myCalc = new Classes.Calculator();
        [Fact]
        public void TestCalculatorAdd()
        {
            Assert.Equal(10, myCalc.Add(5,5));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void TestCalculatorIsOdd(int value)
        {
            Assert.True(myCalc.isOdd(value));
        }
    }

}