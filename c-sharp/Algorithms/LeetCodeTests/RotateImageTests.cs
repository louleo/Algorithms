using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class RotateImageTests
    {
        [Fact]
        public void Test1()
        {
            int[][] matrix = new[]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            };
            int[][] output = new[]
            {
                new[] {7, 4, 1},
                new[] {8, 5, 2},
                new[] {9, 6, 3}
            };

            RotateImageSolution solution = new RotateImageSolution();
            solution.Rotate(matrix);

        }
    }
}