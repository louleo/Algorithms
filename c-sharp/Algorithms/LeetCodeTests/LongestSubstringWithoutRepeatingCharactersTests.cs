using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Fact]
        public void TestCase1()
        {
            string strToBeTested = "abcabcbb";

            LongestSubstringWithoutRepeatingCharactersSolution solution =
                new LongestSubstringWithoutRepeatingCharactersSolution();

            solution.LengthOfLongestSubstring(strToBeTested).Should().Be(3);
        }
    }
}