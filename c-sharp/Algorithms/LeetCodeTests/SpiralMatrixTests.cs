using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class SpiralMatrixTests
    {
        [Fact]
        public void TestCase1()
        {
            int[][] matrix = new[]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            };

            IList<int> output = new List<int>()
            {
                1, 2, 3, 6, 9, 8, 7, 4, 5
            };

            var sol = new SpiralMatrixSolution();
            sol.SpiralOrder(matrix).Should().Equal(output);
        }
    }
}