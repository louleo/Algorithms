using System;

namespace LeetCode.DynamicProgramming
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums[0];
            }

            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            
            int max = Math.Max(nums[0], nums[1]);
            int[] ans = new int[nums.Length];
            ans[0] = nums[0];
            ans[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                ans[i] = Math.Max(nums[i] + ans[i - 2], ans[i-1]);
            }

            return ans[ans.Length - 1];
        }
    }
}