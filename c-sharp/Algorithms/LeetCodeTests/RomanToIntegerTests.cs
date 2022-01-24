using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void TestCase1()
        {
            var s = "III";
            var result = 3;
            var sol = new RomanToIntegerSolution();
            sol.RomanToInt(s).Should().Be(result);
        }
        
        [Fact]
        public void TestCase2()
        {
            var s = "LVIII";
            var result = 58;
            var sol = new RomanToIntegerSolution();
            sol.RomanToInt(s).Should().Be(result);
        }
        
        [Fact]
        public void TestCase3()
        {
            var s = "MCMXCIV";
            var result = 1994;
            var sol = new RomanToIntegerSolution();
            sol.RomanToInt(s).Should().Be(result);
        }
    }
}