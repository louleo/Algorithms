using System;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class TwoSumTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange 
            int[] nums = new int[]{2,7,11,15};
            int target = 9;
            TwoSumSolution solution = new TwoSumSolution();
            int[] expectedResult = new int[] {0, 1};

            //Act
            int[] result = solution.TwoSum(nums, target);
            
            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}