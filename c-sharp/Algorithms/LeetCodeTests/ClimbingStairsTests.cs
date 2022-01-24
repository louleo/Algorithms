using FluentAssertions;
using LeetCode;
using LeetCode.ClimbingStair;
using Xunit;

namespace LeetCodeTests
{
    public class ClimbingStairsTests
    {
        [Fact]
        public void TestCase1()
        {
            var n = 2;
            var sol = new ClimbingStairsSolution();
            var result = 2;

            sol.ClimbStairs(n).Should().Be(result);
        }
        
        [Fact]
        public void TestCase2()
        {
            var n = 3;
            var sol = new ClimbingStairsSolution();
            var result = 3;

            sol.ClimbStairs(n).Should().Be(result);
        }
        
        [Fact]
        public void TestCase3()
        {
            var n = 35;
            var sol = new ClimbingStairsSolution();
            var result = 14930352;

            sol.ClimbStairs(n).Should().Be(result);
        }
    }
}