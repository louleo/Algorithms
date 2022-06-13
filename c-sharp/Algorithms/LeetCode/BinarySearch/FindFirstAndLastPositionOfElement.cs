namespace LeetCode.BinarySearch
{
    public class FindFirstAndLastPositionOfElement
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int index = BinarySearch(0, nums.Length - 1, nums, target);
            if (index == -1)
            {
                return new[] {-1, -1};
            }

            int left = index - 1;
            int right = index + 1;
            while (left >= 0)
            {
                if (nums[left] == target)
                {
                    left--;
                }
            }

            while (right < nums.Length)
            {
                if (nums[right] == target)
                {
                    right++;
                }
            }

            return new[] {left + 1, right - 1};
        }

        public int BinarySearch(int left, int right, int[] nums, int target)
        {
            if (left <= right)
            {
                int mid = left + ((right - left) / 2);
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

                return BinarySearch(left, right, nums, target);
            }

            return -1;
        }
    }
}