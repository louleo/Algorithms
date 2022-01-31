using System.Runtime.InteropServices;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArraySolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length;
            }

            bool firstDuplicate = true;
            int pointer1 = 1;
            int prevNum = nums[0];
            while (pointer1 < nums.Length)
            {
                if (nums[pointer1] == prevNum)
                {
                    break;
                }

                pointer1++;
            }
            
            int pointer2 = pointer1 + 1;

            
            while (pointer2 < nums.Length)
            {
                if (nums[pointer2] != prevNum)
                {
                    prevNum = nums[pointer2];
                    nums[pointer1] = nums[pointer2];
                    pointer1++;
                }
                pointer2++;
            }

            return pointer1;
        }
    }
}