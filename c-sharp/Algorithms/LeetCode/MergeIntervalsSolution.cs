using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class MergeIntervalsSolution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
            {
                return intervals;
            }
            Stack<int[]> result = new Stack<int[]>();
            Array.Sort(intervals, (a, b) =>
            {
                return a[0] - b[0];
            });

            result.Push(intervals[0]);
            
            for (int i = 1; i < intervals.Length; i++)
            {
                var prev = result.Peek();
                if (intervals[i][0] <= prev[i])
                {
                    prev[0] = Math.Min(prev[0], intervals[i][0]);
                    prev[1] = Math.Max(prev[1], intervals[i][i]);
                }
                else
                {
                    result.Push(intervals[i]);
                }
            }
            

            return result.ToArray();
        }
    }
}