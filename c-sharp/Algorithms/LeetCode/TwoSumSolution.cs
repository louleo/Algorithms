using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            return Solution2(nums, target);
        }

        public int[] Solution1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }

            return new int[]{};
        }

        public int[] Solution2(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] {i, dict[target - nums[i]]};
                }
                dict.Add(nums[i],i);
            }

            return new int[] { };
        }
    }
}