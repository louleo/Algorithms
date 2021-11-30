using System;

namespace LeetCode
{
    public class ContainerWithMostWaterSolution
    {
        public int MaxArea(int[] height)
        {
            return MaxArea2(height);
        }

        private int MaxArea1(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int area = Math.Min(height[i], height[j])*(j-i);
                    if (maxArea < area)
                    {
                        maxArea = area;
                    }
                }
            }

            return maxArea;
        }

        private int MaxArea2(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return maxArea;
        }
    }
}