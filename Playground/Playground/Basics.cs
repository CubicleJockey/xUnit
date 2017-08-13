using System;
using Xunit;

namespace Playground
{
    public class Basics
    {
        [Fact]
        public void BasicFact()
        {
            //Method to test
            bool IsOdd(int number)
            {
                return number % 2 == 1;
            }

            //Odd Checks
            Assert.True(IsOdd(1));
            Assert.True(IsOdd(3));
            Assert.True(IsOdd(5));
            Assert.True(IsOdd(7));
            Assert.True(IsOdd(9));
            Assert.True(IsOdd(11));

            //Evens
            Assert.False(IsOdd(2));
            Assert.False(IsOdd(4));
            Assert.False(IsOdd(6));
            Assert.False(IsOdd(8));
            Assert.False(IsOdd(10));
            Assert.False(IsOdd(12));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(12)]
        [InlineData(14)]
        public void BasicTheory(int value)
        {
            bool IsEven(int number)
            {
                return number % 2 == 0;
            }
            
            Assert.True(IsEven(value));
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 2)]
        [InlineData(3, 1)]
        [InlineData(9, -5)]
        [InlineData(10, -6)]
        public void MultiValueTheory(int lhs, int rhs)
        {
            int Add(int l, int r)
            {
                return l + r;
            }

            Assert.Equal(4, Add(lhs, rhs));
        }
    }
}
