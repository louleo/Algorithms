using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class MergeIntervalsTests
    {
        [Fact]
        public void TestCase1()
        {
            var intervals = new int[][]
            {
                new int[] {1, 3},
                new int[] {2, 6}
            };

            var result = new int[][]
            {
                new int[] {1, 6}
            };

            var sol = new MergeIntervalsSolution();
            sol.Merge(intervals).Should().BeEquivalentTo(result);
        }
    }
}