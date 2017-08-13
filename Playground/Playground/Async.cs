using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Playground
{
    public class Async
    {
        [Fact]
        public async Task ThisWillFailTests()
        {
            //Method to Test
            async Task ThisWillFail()
            {
                const int SECONDS = 5;
                await Task.Delay(TimeSpan.FromSeconds(SECONDS));
                throw new Exception($"Failed after {SECONDS} seconds.");
            }

            var exception = await Assert.ThrowsAsync<Exception>(async () => { await ThisWillFail(); });

            Assert.IsType<Exception>(exception);
            Assert.Equal("Failed after 5 seconds.", exception.Message);
        }

        [Fact]
        public async Task SomeStuffWasReturned()
        {
            //Method to Test
            async Task<IEnumerable<string>> ReturnSomeStuff()
            {
                const int SECONDS = 5;
                await Task.Delay(TimeSpan.FromSeconds(SECONDS));
                return new[] { "Stuff", "Thingy", "Potato" };
            }

            var EXPECTED = new[] { "Stuff", "Thingy", "Potato" };
            var result = await ReturnSomeStuff();

            var check = result.ToArray();

            Assert.Equal(3, check.Length);
            for (var i = 0; i < EXPECTED.Length; i++)
            {
                Assert.Equal(EXPECTED[i], check[i]);
            }
        }
    }
}
