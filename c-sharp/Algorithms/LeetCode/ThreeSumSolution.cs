using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;

namespace LeetCode
{

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
                
                
                for (int first = 0; first < length - 2; first++)
                {
                    if (first > 0 && nums[first] == nums[first - 1])
                    {
                        continue;
                    }


                    for (int second = first + 1; second < length - 1; second++)
                    {
                        if (second > first + 1 && nums[second] == nums[second - 1])
                        {
                            continue;
                        }

                        for (int third = second + 1; third < length; third++)
                        {
                            if (third > second + 1 && nums[third] == nums[third - 1])
                            {
                                continue;
                            }

                            int sum = nums[first] + nums[second] + nums[third];
                            if (sum == 0)
                            {
                                results.Add(new List<int>{nums[first], nums[second], nums[third]});
                            }else if (sum > 0)
                            {
                                break;
                            }
                        }
                    }
                    
                }

                return results;
            }
        }
        
    
}