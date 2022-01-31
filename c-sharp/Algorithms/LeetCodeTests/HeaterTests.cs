using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class HeaterTests
    {
        [Fact]
        public void TestCase1()
        {
            int[] houses = new[]
                {
                    282475249,622650073,984943658,144108930,470211272,101027544,457850878,458777923
                };

            int[] heaters = new[]
            {
                823564440,115438165,784484492,74243042,114807987,137522503,441282327,16531729,823378840,143542612
            };

            int output = 161834419;

            var sol = new HeatersSolution();
            sol.FindRadius(houses, heaters).Should().Be(output);
        }
    }
}