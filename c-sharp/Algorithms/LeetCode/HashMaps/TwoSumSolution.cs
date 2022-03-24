using System.Collections.Generic;

namespace LeetCode.HashMaps
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[]
                    {
                        dict[target - nums[i]],
                        i
                    };
                }
                dict.TryAdd(nums[i], i);
            }
            return new int[]{};
        }
    }
}