using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class LongestPalindromicSubstringTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string strInput = "babad";
            string expectedOutput = "bab";
            LongestPalindromicSubstringSolution solution = new LongestPalindromicSubstringSolution();
            
            //Act
            string result = solution.LongestPalindrome(strInput);
            
            //Assert
        }
    }
}