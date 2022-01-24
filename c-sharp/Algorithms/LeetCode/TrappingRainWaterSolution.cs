using System;

namespace LeetCode
{
    public class TrappingRainWaterSolution
    {
        public int Trap(int[] height)
        {
            if (height.Length < 2)
            {
                return 0;
            }
            
            //left maxes
            int n = height.Length;

            int[] leftMax = new int[n];
            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }
            
            int[] rightMax = new int[n]; 
            rightMax[n-1] = height[n-1];
            for (int i = n -2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += (Math.Min(leftMax[i], rightMax[i]) - height[i]);
            }

            return result;
        }
    }
}