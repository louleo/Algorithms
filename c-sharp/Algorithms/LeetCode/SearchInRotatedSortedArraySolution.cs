namespace LeetCode
{
    public class SearchInRotatedSortedArraySolution
    {
        public int Search(int[] nums, int target)
        {
            int midIndex = nums.Length - 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] < nums[i])
                {
                    midIndex = i;
                    break;
                }
            }

            int left = BinarySearch(nums, target, 0, midIndex);
            int right = BinarySearch(nums, target, midIndex + 1, nums.Length - 1);

            if (left >= 0)
            {
                return left;
            }

            if (right >= 0)
            {
                return right;
            }

            return -1;
        }

        public int BinarySearch(int[] nums, int target, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;
                if (target == nums[midIndex])
                {
                    return midIndex;
                }
                else
                {
                    if (target > nums[midIndex])
                    {
                        return BinarySearch(nums, target, midIndex + 1, rightIndex);
                    }
                    else
                    {
                        return BinarySearch(nums, target, leftIndex, midIndex);
                    }
                }
            }

            return nums[rightIndex] == target ? rightIndex : -1;
        }
    }
}