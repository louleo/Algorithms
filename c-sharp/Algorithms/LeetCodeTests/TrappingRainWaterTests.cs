using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class TrappingRainWaterTests
    {
        [Fact]
        public void TestCase1()
        {
            int[] height = new[] {4, 2, 0, 3, 2, 5};
            var sol = new TrappingRainWaterSolution();
            int result = sol.Trap(height);
            result.Should().Be(9);
        }
    }
}