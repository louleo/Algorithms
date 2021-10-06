using System;

namespace LeetCode
{
    public class JumpGameTwoSolution
    {
        public int Jump(int[] nums)
        {
            return Solution1(nums);
        }

        private int Solution1(int[] nums)
        {
            int end = 0;
            int maxPosition = 0;
            int steps = 0;
            int length = nums.Length;

            for (int i = 0; i < length - 1; i++)
            {
                maxPosition = Math.Max(maxPosition, i + nums[i]);
                if (i == end)
                {
                    end = maxPosition;
                    steps++;
                }
            }

            return steps;
        }
    }
}