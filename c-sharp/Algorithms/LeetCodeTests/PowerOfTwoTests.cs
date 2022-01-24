using System;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class PowerOfTwoTests
    {
        private PowerOfTwoSolution sol = new PowerOfTwoSolution();

        [Fact]
        public void TestCase1()
        {
            sol.IsPowerOfTwo2(16).Should().BeTrue();
        }
        
        [Fact]
        public void TestCase2()
        {
            sol.IsPowerOfTwo2(17).Should().BeFalse();
        }
    }
}