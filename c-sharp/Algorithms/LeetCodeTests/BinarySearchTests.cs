using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void TestCase1()
        {
            int[] inputs = new[]
            {
                -1, 0, 3, 5, 9, 12
            };

            BinarySearchSolution solution = new BinarySearchSolution();

            solution.Search(inputs, 2).Should().Be(-1);
        }
    }
}