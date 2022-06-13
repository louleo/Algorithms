namespace LeetCode.ArrayProblems
{
    public class ArrayRotate
    {
        public void Rotate(int[] nums, int k)
        {
            
            if (nums.Length < 2)
            {
                return;
            }
            bool[] visited = new bool[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                int startIndex = i + k;
                int temp = nums[i];
                while(startIndex >= nums.Length)
                {
                    startIndex -= nums.Length;
                }
                while (!visited[startIndex])
                {
                    visited[startIndex] = true;
                    (temp, nums[startIndex]) = (nums[startIndex], temp);
                    startIndex += k;
                    while (startIndex >= nums.Length)
                    {
                        startIndex -= nums.Length;
                    }
                }
            }
        }
    }
}