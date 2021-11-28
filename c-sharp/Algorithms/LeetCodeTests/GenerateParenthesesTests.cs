using System;
using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class GenerateParenthesesTests
    {
        [Fact]
        public void TestCase1()
        {
            var input = 3;
            IList<string> expectedResults = new List<string>()
            {
                "((()))", "(()())", "(())()", "()(())", "()()()"
            };
            var sol = new GenerateParenthesesSolution();

            sol.GenerateParenthesis(input).Should().BeEquivalentTo(expectedResults);
        }
        
        [Fact]
        public void TestCase2()
        {
            var input = 4;
            var expectedResults = "(())(())";
            var expectedCount = 14;
            var sol = new GenerateParenthesesSolution();

            var result = sol.GenerateParenthesis(input);
            result.Should().Contain(expectedResults);
            result.Count.Should().Be(expectedCount);
        }
    }
}