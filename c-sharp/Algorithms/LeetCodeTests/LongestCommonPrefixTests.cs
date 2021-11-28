using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class LongestCommonPrefixTests
    {
        [Fact]
        public void TestCase1()
        {
            var strs = new string[]
            {
                "dog", "flow", "flight"
            };
            var expectedResult = "";
            var sol = new LongestCommonPrefixSolution();
            sol.LongestCommonPrefix(strs).Should().Be(expectedResult);
        }

        [Fact]
        public void TestCase2()
        {
            var strs = new string[]
            {
                "flowers", "flow", "flight"
            };
            var expectedResult = "fl";
            var sol = new LongestCommonPrefixSolution();
            sol.LongestCommonPrefix(strs).Should().Be(expectedResult);
        }
    }
}