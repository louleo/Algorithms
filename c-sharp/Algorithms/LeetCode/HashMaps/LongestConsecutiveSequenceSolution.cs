using System;
using System.Collections.Generic;

namespace LeetCode.HashMaps
{
    public class LongestConsecutiveSequenceSolution
    {
        public int LongestConsecutive(int[] nums) {
            if (nums.Length == 0)
            {
                return 0;
            }
            
            Array.Sort(nums);
            //key: nums[i] and value will be longestLength
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int longest = 1;
            dict[nums[0]] = 1;
            
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i-1] == 1)
                {
                    dict[nums[i]] = dict[nums[i - 1]] + 1;
                    longest = Math.Max(longest, dict[nums[i]]);
                }
                else if(nums[i] != nums[i-1])
                {
                    dict[nums[i]] = 1;
                }
            }

            return longest;
        }
    }
}