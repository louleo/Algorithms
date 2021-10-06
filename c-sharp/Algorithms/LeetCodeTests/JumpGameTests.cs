using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class JumpGameTests
    {
        [Fact]
        public void TestCase1()
        {
            int[] arr = new[]
            {
                2, 3, 1, 1, 4
            };

            JumpGameTwoSolution jumpGameTwoSolution = new JumpGameTwoSolution();

            jumpGameTwoSolution.Jump(arr).Should().Be(2);
        }
        
        [Fact]
        public void TestCase2()
        {
            int[] arr = new[]
            {
                2, 3, 5, 20, 4
            };

            JumpGameTwoSolution jumpGameTwoSolution = new JumpGameTwoSolution();

            jumpGameTwoSolution.Jump(arr).Should().Be(2);
        }
    }
}