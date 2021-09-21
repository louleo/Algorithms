using System;
using System.Collections;
using System.Collections.Generic;
using Algorithms.Sort;
using FluentAssertions;
using Xunit;

namespace AlgorithmsTests
{
    public class SortTests
    {
        [Theory]
        [MemberData(nameof(TestingData))]
        public void BubbleSort_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            BubbleSortHelper.Sort(arr1);
            
            //Assert 
            CompareArraysWithOrder(arr1, arr2).Should().BeTrue();
        }        
        
        [Theory]
        [MemberData(nameof(TestingData))]
        public void SelectionSort_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            SelectionSortHelper.Sort(arr1);
            
            //Assert 
            CompareArraysWithOrder(arr1, arr2).Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(TestingData))]
        public void InsertionSort_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            InsertionSortHelper.Sort(arr1);
            
            //Assert 
            CompareArraysWithOrder(arr1, arr2).Should().BeTrue();
        }


        private bool CompareArraysWithOrder(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<object[]> TestingData => new List<object[]>
        {
            new object[] { new int[] {9, 6, 4, 8, 0, 19, 439, 4, 35}},
            new object[] { new int[] {1, 5, 12, 14, 13, 125, 18, 15, 2, 33, 15}},
            new object[] { new int[] { }},
            new object[] { new int[] {2, 1}}
        };
    }
}