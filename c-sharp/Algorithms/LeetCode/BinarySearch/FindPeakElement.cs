namespace LeetCode.BinarySearch
{
    public class FindPeakElementSolution
    {
        public int FindPeakElement(int[] nums) {
            if (nums.Length == 1)
            {
                return 0;
            }

            if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            var length = nums.Length;
            int mid = length / 2;
            while (mid != getPeek(mid, nums))
            {
                mid = getPeek(mid, nums);
            }

            return mid;

        }

        public int getPeek(int index, int[] nums)
        {
            int length = nums.Length;
            int left = index - 1;
            int right = index + 1;
            int maximum = index;
            if (left >= 0)
            {
                if (nums[left] > nums[index])
                {
                    maximum = left;
                }
            }

            if (right < length)
            {
                if (nums[right] > nums[maximum])
                {
                    maximum = right;
                }
            }

            return maximum;
        }
    }
}