using System;

namespace LeetCode
{
    public class LargestNumberSolution
    {
        public string LargestNumber(int[] nums) {
            
            Array.Sort(nums, (left, right) =>
            {
                long sLeft = 10, sRight = 10;
                while (sLeft <= left)
                {
                    sLeft *= 10;
                }

                while (sRight <= right)
                {
                    sRight *= 10;
                }
                return (int)(right * sLeft + left - (left * sRight + right));
            });

            if (nums[0] == 0)
            {
                return "0";
            }

            int ptr = 0;
            int len = nums.Length;
            string ans = "";
            while (ptr < len)
            {
                ans += nums[ptr].ToString();
                ptr++;
            }

            
            return ans;
        }
        
    }
}