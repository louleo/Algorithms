using System;
using Algorithms.Search;
using FluentAssertions;
using Xunit;

namespace AlgorithmsTests
{
    public class SearchTests
    {
        [Fact]
        public void BinarySearch_return_correct_index()
        {
            //Arrange 
            int[] arr = new[]
            {
                1, 3, 5, 7, 9
            };

            //Act
            int result = BinarySearchHelper.BinarySearch(arr, 5);
            
            //Assert
            result.Should().Be(Array.BinarySearch(arr, 5));
        }

        [Fact]
        public void LinearSearch_return_correct_index()
        {
            //Arrange 
            int[] arr = new[]
            {
                2, 4, 6, 8, 10
            };
            
            //Act 
            int result = LinearSearchHelper.LinearSearch(arr, 6);
            
            //Assert
            result.Should().Be(Array.IndexOf(arr, 6));
        }
    }
}