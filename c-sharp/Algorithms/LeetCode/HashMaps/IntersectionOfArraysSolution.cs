using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashMaps
{
    public class IntersectionOfArraysSolution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                set1.Add(nums1[i]);
            }

            for (int j = 0; j < nums2.Length; j++)
            {
                if (set1.Contains(nums2[j]))
                {
                    set2.Add(nums2[j]);
                }
            }
            
            return set2.ToArray();
        }
    }
}