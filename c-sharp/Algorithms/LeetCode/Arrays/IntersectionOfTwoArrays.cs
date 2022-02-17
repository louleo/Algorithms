using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace LeetCode.Arrays
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> ans = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int pointer1 = 0;
            int pointer2 = 0;
            while (pointer1 < nums1.Length && pointer2 < nums2.Length)
            {
                if (nums1[pointer1] == nums2[pointer2])
                {
                    ans.Add(nums1[pointer1]);
                    pointer1++;
                    pointer2++;
                }else if (nums1[pointer1] > nums2[pointer2])
                {
                    pointer2++;
                }
                else
                {
                    pointer1++;
                }
            }

            return ans.ToArray();
        }
    }
}