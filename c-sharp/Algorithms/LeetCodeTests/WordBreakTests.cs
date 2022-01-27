using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class WordBreakTests
    {
        [Fact]
        public void TestCase1()
        {
            var sol = new WordBreakSolution();
            var wordDict = new string[]
            {
                "leet", "code"
            };
            var input = "leetcode";
            var result = sol.WordBreak(input, wordDict);

            result.Should().BeTrue();
        }
    }
}