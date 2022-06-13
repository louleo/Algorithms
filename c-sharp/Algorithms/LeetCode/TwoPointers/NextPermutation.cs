namespace LeetCode.TwoPointers
{
    public class NextPermutationSolution
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 1;
            while (i > 0)
            {
                int j = i - 1;
                if (nums[j] < nums[i])
                {
                    int t = nums.Length - 1;
                    while (t > j)
                    {
                        if (nums[t] > nums[j])
                        {
                            (nums[t], nums[j]) = (nums[j], nums[t]);
                            Reverse(nums, j + 1);
                            return;
                        }

                        t--;
                    }
                }

                i--;
            }

            Reverse(nums, 0);
        }

        protected void Reverse(int[] nums, int startIndex)
        {
            int left = startIndex;
            int right = nums.Length - 1;
            while (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
                right--;
            }
        }
    }
}