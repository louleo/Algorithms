using System.Collections.Generic;

namespace LeetCode
{
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> numsSet = new HashSet<int>();
            foreach (var num in nums)
            {
                bool added = numsSet.Add(num);
                if (!added)
                {
                    return true;
                }
            }

            return false;
        }
    }
}