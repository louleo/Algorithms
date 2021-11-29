using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class ValidParenthesesTests
    {
        [Fact]
        public void TestCase1()
        {
            var input = "()";
            var sol = new ValidParenthesesSolution();
            var output = true;

            sol.IsValid(input).Should().Be(output);
        }
        
        [Fact]
        public void TestCase2()
        {
            var input = "()[]{}";
            var sol = new ValidParenthesesSolution();
            var output = true;

            sol.IsValid(input).Should().Be(output);
        }
        
        [Fact]
        public void TestCase3()
        {
            var input = "()[]}";
            var sol = new ValidParenthesesSolution();
            var output = false;

            sol.IsValid(input).Should().Be(output);
        }
    }
}