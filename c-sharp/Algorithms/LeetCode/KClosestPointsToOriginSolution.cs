using System;

namespace LeetCode
{
    public class KClosestPointsToOriginSolution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            int[][] result = new int[k][];
            Array.Sort(points, (p1, p2) =>
            {
                double p1Distance = Math.Pow(p1[0], 2) + Math.Pow(p1[1], 2);
                double p2Distance = Math.Pow(p2[0], 2) + Math.Pow(p2[1], 2);
                return (int)(p1Distance - p2Distance);
            });
            for (int i = 0; i < k; i++)
            {
                result[i] = points[i];
            }

            return result;
        }
    }
}