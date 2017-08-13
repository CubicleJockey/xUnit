using System;
using Xunit;

namespace Playground
{
    public class Basics
    {
        [Fact]
        public void BasicFact()
        {
            bool IsOdd(int number)
            {
                return number % 2 != 0;
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
    }
}
