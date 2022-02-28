using System;

namespace LeetCode.DynamicProgramming
{
    public class LongestIncreasingSubsequenceSolution
    {
        public int LengthOfLIS(int[] nums)
        {
            return nums.Length;
        }

        public int LengthOfLIS1(int[] nums)
        {
            int[] res = new int[nums.Length];
            int max = 1;
            int length = nums.Length;
            res[0] = 1;
            for (int i = 1; i < length; i++)
            {
                res[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        res[i] = Math.Max(res[j] + 1, res[i]);
                        max = Math.Max(res[i], max);
                    }
                }
            }

            return max;
        }
    }
}