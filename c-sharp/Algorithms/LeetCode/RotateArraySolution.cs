namespace LeetCode
{
    public class RotateArraySolution
    {
        public void Rotate(int[] nums, int k) {
            if (k == 0 || nums.Length < 2)
            {
                return;
            }

            int toBeSet = nums[0];
            int temp;
            for (int i = 1; i < nums.Length + k; i++)
            {
                temp = toBeSet;
                toBeSet = nums[i];
                nums[i] = temp;
            }

            nums[0] = toBeSet;

            Rotate(nums, k - 1);
        }

        public void RotateNew(int[] nums, int k)
        {
            if (k == 0 || nums.Length < 2)
            {
                return;
            }
            int[] result = new int[nums.Length];
            int toBeSet = nums[0];
            int temp;
            int index = k;
            for (int i = 0; i < nums.Length; i++)
            {
                index = i + k;
                while ( index >= nums.Length)
                {
                    index -= nums.Length;
                }
                result[index] = nums[i];
            }
            
            result.CopyTo(nums, 0);
        }
    }
}