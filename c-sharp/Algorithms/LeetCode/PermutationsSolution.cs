using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class PermutationsSolution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();

            results.Add(nums.ToList());
            
            InternalPermutation(nums,results, 0);

            return results;
        }

        public void InternalPermutation(int[] nums, IList<IList<int>> results, int startIndex)
        {
            for (int i = startIndex +1; i < nums.Length; i++)
            {
                (nums[startIndex], nums[i]) = (nums[i], nums[startIndex]);
                results.Add(nums.ToList());
                InternalPermutation(nums, results, i);
                (nums[startIndex], nums[i]) = (nums[i], nums[startIndex]);
            }
        }
    }
}