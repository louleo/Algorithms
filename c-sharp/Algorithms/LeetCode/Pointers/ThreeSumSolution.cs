using System;
using System.Collections.Generic;

namespace LeetCode
{

        /*
         * Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
         * Notice that the solution set must not contain duplicate triplets.
         */
        public class ThreeSumSolution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                return ThreeSumInternal(nums);
            }

            public IList<IList<int>> ThreeSumInternal(int[] nums)
            {
                Array.Sort(nums);
                int length = nums.Length;
                IList<IList<int>> results = new List<IList<int>>();


                if (length < 3)
                {
                    return results;
                }

                int mid, right;
                for (int left = 0; left < length; left++)
                {
                    
                    if (left > 0 && nums[left] == nums[left - 1]) continue;
                    mid = left + 1;
                    right = length - 1;

                    while (mid < right)
                    {
                        if (mid > left + 1 && nums[mid - 1] == nums[mid])
                        {
                            mid++;
                            continue;
                        }
                        
                        int value = nums[mid] + nums[left] + nums[right];
                        if (value == 0)
                        {
                            results.Add(new List<int>() {nums[mid], nums[left], nums[right]});
                            mid++;
                        }else if (value > 0)
                        {
                            right--;
                        }
                        else
                        {
                            mid++;
                        }
                    }
                }
                

                return results;
            }
        }
        
    
}