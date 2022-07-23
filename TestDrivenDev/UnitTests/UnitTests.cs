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
    }

}