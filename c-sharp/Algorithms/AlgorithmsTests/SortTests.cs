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
            arr1.Should().Equal(arr2);
        }          
        
        [Theory]
        [MemberData(nameof(TestingData))]
        public void BubbleSort_Helper_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            SortingHelper.BubbleSort(arr1);
            
            //Assert 
            arr1.Should().Equal(arr2);
        }        
        
        [Theory]
        [MemberData(nameof(TestingData))]
        public void SelectionSort_Helper_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            SortingHelper.SelectionSort(arr1);
            
            //Assert 
            arr1.Should().Equal(arr2);
        }     
        
        
        [Theory]
        [MemberData(nameof(TestingData))]
        public void InsertSort_Helper_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            SortingHelper.InsertionSort(arr1);
            
            //Assert 
            arr1.Should().Equal(arr2);
        }     
        
        
        [Theory]
        [MemberData(nameof(TestingData))]
        public void QuickSort_Helper_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            SortingHelper.QuickSort(arr1, 0, arr1.Length -1);
            
            //Assert 
            arr1.Should().Equal(arr2);
        }     
        
        
        [Theory]
        [MemberData(nameof(TestingData))]
        public void MergeSort_Helper_return_correct_array(int[] arr1)
        {
            //Arrange
            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            Array.Sort(arr2);
            
            //Act
            SortingHelper.MergeSort(arr1,0, arr1.Length -1);
            
            //Assert 
            arr1.Should().Equal(arr2);
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
            arr1.Should().Equal(arr2);
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
            arr1.Should().Equal(arr2);
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