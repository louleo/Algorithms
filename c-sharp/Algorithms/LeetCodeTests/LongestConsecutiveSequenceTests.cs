using System.Text.Json.Serialization;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class LongestConsecutiveSequenceTests
    {
        [Fact]
        public void TestCase1()
        {
            int[] nums = new[]
            {
                100, 4, 200, 1, 3, 2
            };
            int result = 4;
            var sol = new LongestConsecutiveSequenceSolution();
            sol.LongestConsecutive(nums).Should().Be(result);
        }
        
        [Fact]
        public void TestCase2()
        {
            int[] nums = new[]
            {
                0,3,7,2,5,8,4,6,0,1
            };
            int result = 9;
            var sol = new LongestConsecutiveSequenceSolution();
            sol.LongestConsecutive(nums).Should().Be(result);
        }
        
        [Fact]
        public void TestCase3()
        {
            int[] nums = new[]
            {
                0,1,2,1
            };
            int result = 3;
            var sol = new LongestConsecutiveSequenceSolution();
            sol.LongestConsecutive(nums).Should().Be(result);
        }        
        
        [Fact]
        public void TestCase4()
        {
            int[] nums = new[]
            {
                9,1,-3,2,4,8,3,-1,6,-2,-4,7
            };
            int result = 4;
            var sol = new LongestConsecutiveSequenceSolution();
            sol.LongestConsecutive(nums).Should().Be(result);
        }
    }
}