namespace LeetCode
{
    public class JumpGameTwoSolution
    {
        public int Jump(int[] nums)
        {
            return Solution1(nums);
        }

        private int Solution1(int[] nums)
        {
            int currentIndex = 0;
            int maxJumpStep = nums[currentIndex];
            int stepNum = 0;

            while (maxJumpStep + currentIndex < nums.Length -1)
            {
                int maxIndex = currentIndex+maxJumpStep;
                for (int i = maxJumpStep; i > 0; i--)
                {
                    if (nums[currentIndex+i] > nums[maxIndex])
                    {
                        maxIndex = currentIndex + i;
                    }
                }

                currentIndex = maxIndex;
                maxJumpStep = nums[currentIndex];
                stepNum++;
            }

            return stepNum + 1;

        }
    }
}