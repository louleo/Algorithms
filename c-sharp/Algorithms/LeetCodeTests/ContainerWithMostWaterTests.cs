using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class ContainerWithMostWaterTests
    {
        [Theory]
        [InlineData(new int[]{1,8,6,2,5,4,8,3,7}, 49)]
        [InlineData(new int[]{1,1}, 1)]
        [InlineData(new int[]{4,3,2,1,4}, 16)]
        [InlineData(new int[]{1,2,1}, 2)]
        public void TestCases(int[] height, int result)
        {
            var sol = new ContainerWithMostWaterSolution();
            sol.MaxArea(height).Should().Be(result);
        }
    }
}