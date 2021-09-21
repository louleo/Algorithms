using System;
using System.Collections.Generic;

namespace Algorithms.Search
{
    public static class BinarySearchHelper
    {
        public static int BinarySearch(int[] arr, int item)
        {
            if (arr.Length > 0)
            {
                int leftIndex = 0;
                int rightIndex = arr.Length - 1;

                while (leftIndex < rightIndex)
                {
                    int midIndex = (leftIndex + rightIndex) / 2;

                    if (arr[midIndex] < item)
                    {
                        leftIndex = midIndex;
                    }else if (arr[midIndex] > item)
                    {
                        rightIndex = midIndex;
                    }
                    else
                    {
                        return midIndex;
                    }
                }
            }
            
            return -1;
        }
    }
}