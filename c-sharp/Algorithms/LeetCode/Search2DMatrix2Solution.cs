namespace LeetCode
{
    public class Search2DMatrix2Solution
    {
        public bool SearchMatrix(int[][] matrix, int target) {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (BinarySearch(matrix[i], target))
                {
                    return true;
                }
            }

            return false;
        }

        private bool BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int mid = (right + left) / 2;
                if (mid == left || mid ==right)
                {
                    break;
                }
                
                if (arr[mid] == target)
                {
                    return true;
                }else if (arr[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return false;
        }
    }
}