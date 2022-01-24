using System;

namespace LeetCode
{
    public class MaximumSubarraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            int[] dpnums = new int[nums.Length];
            int ans = nums[0];
            dpnums[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                dpnums[i] = Math.Max(dpnums[i - 1] + nums[i], nums[i]);
                ans = Math.Max(dpnums[i], ans);
            }
            return ans;
        }
    }
}