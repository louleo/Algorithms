using System;

namespace LeetCode.Arrays
{
    public class MaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            int[] maxF = new int[nums.Length];
            int[] minF = new int[nums.Length];
            maxF[0] = nums[0];
            minF[0] = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxF[i] = Math.Max(nums[i] * maxF[i-1], Math.Max(nums[i] * minF[i-1], nums[i]));
                minF[i] = Math.Min(nums[i] * maxF[i-1], Math.Min(nums[i] * minF[i-1], nums[i]));
                max = Math.Max(max, maxF[i]);
                max = Math.Max(max, minF[i]);
            }

            return max;
        }
    }
}