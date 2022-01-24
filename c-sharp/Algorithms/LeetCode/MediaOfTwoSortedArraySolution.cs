using System;

namespace LeetCode
{
    public class MediaOfTwoSortedArraySolution
    {
        
        /*
         * 
         */
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int totalLength = length1 + length2;
            if (totalLength % 2 == 0)
            {
                int index = totalLength / 2;
                return (FindMedianSortedArrays(nums1, nums2, index) + FindMedianSortedArrays(nums1, nums2, index + 1)) /
                       2;
            }
            else
            {
                int index = totalLength / 2;
                return FindMedianSortedArrays(nums1, nums2, index);
            }
        }

        private double FindMedianSortedArrays(int[] nums1, int[] nums2, int index)
        {
            int currentIndex = 0; 
            if (nums1.Length > nums2.Length)
            {
                   
            }

            return 0.0;
        }

    }
}