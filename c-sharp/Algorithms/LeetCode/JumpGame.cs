using System;

namespace LeetCode
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int length = nums.Length;
            int[] steps = new int[length];
            steps[0] = nums[0];
            int max = steps[0];
            for (int i = 1; i < length; i++)
            {
                if (i > max)
                {
                    return false;
                }
                steps[i] = i + nums[i];
                max = Math.Max(max, steps[i]);
                if (max >= length - 1)
                {
                    return true;
                }
            }

            return true;
        }
    }
}