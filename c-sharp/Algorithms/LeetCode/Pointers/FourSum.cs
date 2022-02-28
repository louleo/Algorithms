using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class FourSumSolution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> ans = new List<IList<int>>();
            Array.Sort(nums);

            if (nums.Length > 4)
            {
                
                for (int i = 0; i < nums.Length - 3; i++)
                {
                    if (i != 0 && nums[i] == nums[i-1])
                    {
                        continue;
                    }
                    for (int j = i+1; j < nums.Length - 2; j++)
                    {
                        if (j!= i+1 && nums[j] == nums[j-1])
                        {
                            continue;
                        }
                        for (int k = j+1; k < nums.Length - 1; k++)
                        {
                            
                            if(k != j+1 && nums[k] == nums[k-1] ) continue;
                            for (int l = k+1; l < nums.Length; l++)
                            {
                                if (l != k+1 && nums[l] == nums[l-1])
                                {
                                    continue;
                                }
                                int value = nums[i] + nums[j] + nums[k] + nums[l];
                                if (value > target)
                                {
                                    break;
                                }

                                if (value == target)
                                {
                                    List<int> res = new List<int>()
                                    {
                                        nums[i], nums[j], nums[k], nums[l]
                                    };
                                    ans.Add(res);
                                }
                            }
                        }
                    }
                }
                
            }
            return ans;
        }
    }
}