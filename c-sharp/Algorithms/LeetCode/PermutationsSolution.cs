using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace LeetCode
{
    public class PermutationsSolution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();

            IList<int> list = nums.ToList();
            
            BackTrace(list, list.Count, 0, results);

            return results;
        }

        public void BackTrace(IList<int> nums, int end, int first, IList<IList<int>> result)
        {
            if (end == first)
            {
                int[] newNums = new int[end];
                nums.CopyTo(newNums, 0);
                result.Add(newNums.ToList());
            }

            for (int i = first; i < end; i++)
            {
                (nums[i], nums[first]) = (nums[first], nums[i]);
                BackTrace(nums, end, first+1, result);
                (nums[i], nums[first]) = (nums[first], nums[i]);
            }
        }
    }
}