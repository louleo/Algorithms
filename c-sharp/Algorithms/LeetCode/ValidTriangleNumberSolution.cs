using System;

namespace LeetCode
{
    public class ValidTriangleNumberSolution
    {
        public int TriangleNumber(int[] nums) {

            if (nums.Length < 3)
            {
                return 0;
            }
            
            Array.Sort(nums);
            int ans = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 0)
                {
                    continue;
                }
                for (int j = i+1; j < nums.Length - 1; j++)
                {
                    if (nums[j] == 0)
                    {
                        continue;
                    }
                    for (int k = nums.Length - 1; k > j ;k--)
                    {
                        if (nums[k] == 0)
                        {
                            continue;
                        }

                        if (nums[i] + nums[j] > nums[k])
                        {
                            ans += (k-j);
                            break;
                        }
                    }
                }
            }

            return ans;
        }
    }
}