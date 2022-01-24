using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class ReverseWordsInAStringTests
    {
        [Fact]
        public void TestCase1()
        {
            var input = "the sky is blue";
            var output = "blue is sky the";

            var sol = new ReverseWordsInAStringSolution();
            sol.ReverseWords(input).Should().Be(output);
        }
        
        [Fact]
        public void TestCase2()
        {
            var input = "  hello world  ";
            var output = "world hello";

            var sol = new ReverseWordsInAStringSolution();
            sol.ReverseWords(input).Should().Be(output);
        }
    }
}