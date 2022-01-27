namespace LeetCode
{
    public class ProductOfArrayExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] leftAns = new int[nums.Length];
            leftAns[0] = 1;
            int[] rightAns = new int[nums.Length];
            rightAns[nums.Length - 1] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                leftAns[i] = nums[i - 1] * leftAns[i - 1];
            }

            for (int j = nums.Length - 2; j >= 0; j--)
            {
                rightAns[j] = rightAns[j + 1] * nums[j + 1];
            }

            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = leftAns[i] * rightAns[i];
            }

            return ans;
        }
    }
}