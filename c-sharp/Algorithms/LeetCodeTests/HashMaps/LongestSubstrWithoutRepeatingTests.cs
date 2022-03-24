using FluentAssertions;
using LeetCode.HashMaps;
using Xunit;

namespace LeetCodeTests.HashMaps
{
    
    public class LongestSubstrWithoutRepeatingTests
    {
        [Theory]
        [InlineData("abcabcbb",3)]
        [InlineData("bbbbbbb",1)]
        [InlineData("pwwkew",3)]
        [InlineData("au",2)]
        [InlineData("abba",2)]
        [InlineData(" ",1)]
        [InlineData("tmmzuxt",5)]
        public void TestCase(string s, int ans)
        {
            var sol = new LongestSubstringWithoutRepeatingCharactersSolution();
            var result = sol.LengthOfLongestSubstring(s);
            result.Should().Be(ans);
        }    
    }
}