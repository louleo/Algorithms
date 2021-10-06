using System;

namespace LeetCode
{
    public class BinarySearchSolution
    {
        public int Search(int[] nums, int target)
        {
            Array.Sort(nums);
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        public int BinarySearch(int[] nums, int startIndex, int endIndex, int target)
        {
            if(endIndex < startIndex){
                return -1;
            }
            
            if (startIndex == endIndex)
            {
                if (target == nums[startIndex])
                {
                    return startIndex;
                }
                else
                {
                    return -1;
                }
            }

            int midIndex = (startIndex + endIndex) / 2;
            if (target > nums[midIndex])
            {
                return BinarySearch(nums, midIndex+1, endIndex, target);
            }else if (target < nums[midIndex])
            {
                return BinarySearch(nums, startIndex, midIndex-1, target);
            }
            else
            {
                return midIndex;
            }
        }
    }
}