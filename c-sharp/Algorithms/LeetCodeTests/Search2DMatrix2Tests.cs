using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class Search2DMatrix2Tests
    {
        [Fact]
        public void TestCase1()
        {
            int[][] matrix = new[]
            {
                new[]
                {
                    1, 4, 7, 11, 15
                },
                new[]
                {
                    2, 5, 8, 12, 19
                }
            };

            var sol = new Search2DMatrix2Solution();
            sol.SearchMatrix(matrix, 5).Should().Be(true);
        }
    }
}