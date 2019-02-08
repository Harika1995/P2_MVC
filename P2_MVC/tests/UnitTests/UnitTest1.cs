using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        int Multiplication(int a,int b)
        {
            return a * b;
        }
        [Fact]
        public void Multipilaction_WorksWithTwoPositiveIntegers()
        {
            var expected = 4;
            var a = 2;
            var b = 2;
            var actual = Multiplication(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(4, -2, -2)]
        [InlineData(0, 0, 0)]
        public void Multiplication_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, Multiplication(n1, n2));
        }


    }
}
