using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    //15
    public class ThreeSumTests
    {
        [Fact]
        public void TestCase1()
        {
            var nums = new int[]
            {
                -1, 0, 1, 2, -1, -4
            };
            var result = new List<IList<int>>()
            {
                new List<int>() {-1,-1,2},
                new List<int>() {-1,0,1}
            };
            var sol = new ThreeSumSolution();

            sol.ThreeSum(nums).Should().BeEquivalentTo(result);
        }
        
        [Fact]
        public void TestCase2()
        {
            var nums = new int[]
            {
                0,0,0,0
            };
            var result = new List<IList<int>>()
            {
                new List<int>() {0,0,0},
            };
            var sol = new ThreeSumSolution();

            sol.ThreeSum(nums).Should().BeEquivalentTo(result);
        }
    }
}
