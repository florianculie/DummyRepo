using System;
using Xunit;

namespace Dummy.Tests
{
    public class MathTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(3, 1)]
        [InlineData(1, 4)]
        [InlineData(5, 1)]
        public void Add_AddsTwoNumbers(int a, int b)
        {
            Assert.Equal(a + b, Math.Add(a, b));
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(4, 25)]
        public void Factorial_ReturnsTheRightAnswers(int n, int result)
        {
            Assert.Equal(result, Math.Factorial(n));
        }

        [Fact]
        public void Factorial_ThrowsExceptionWhenArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Math.Factorial(0));
        }
    }
}
