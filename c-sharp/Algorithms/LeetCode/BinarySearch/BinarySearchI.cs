namespace LeetCode.BinarySearch
{
    public class BinarySearchI
    {
        public int Search704(int[] nums, int target)
        {
            
            return BinarySearch(nums, 0, nums.Length-1, target);
        }

        private int BinarySearch(int[] nums, int left, int right, int target)
        {
            if (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }else if (nums[mid] > target)
                {
                    return BinarySearch(nums, left, mid - 1, target);
                }
                else
                {
                    return BinarySearch(nums, mid + 1, right, target);
                }
            }
            return -1;
        }
        
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while(left < right){
                int mid = left + (right-left)/2;
                if(IsBadVersion(mid)){
                    right = mid;
                }else{
                    left = mid+1;
                }
            }
            return left;
        }

        public int SearchInsert(int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;

            if(target > nums[right]){
                return right + 1;
            }
            if(target < nums[left]){
                return left;
            }

            while(left <= right){
                int mid = left + (right - left)/2;
                if(nums[mid] == target){
                    return mid;
                }else if(nums[mid] > target){
                    right = mid - 1;
                }else{
                    left = mid + 1;
                }
            }
            return left;
        }

        private bool IsBadVersion(int version)
        {
            return false;
        }
    }
}