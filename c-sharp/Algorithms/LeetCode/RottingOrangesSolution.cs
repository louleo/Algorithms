using System.Collections.Generic;

namespace LeetCode
{
    public class RottingOrangesSolution
    {
        
        public int OrangesRotting(int[][] grid)
        {

            int totalFresh = 0;
            int minute = 0;
            Queue<(int, int)> queue = new Queue<(int I, int J)>();
            int maxI = grid.Length;
            int maxJ = grid[0].Length;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        totalFresh += 1;
                    }else if (grid[i][j] == 2)
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }

            int currentLength = queue.Count;
            while (queue.Count > 0 && totalFresh > 0)
            {
                minute++;
                for (int i = 0; i < currentLength; i++)
                {
                    (int I, int J) currentPoint = queue.Dequeue();
                    if (currentPoint.I + 1 < maxI && grid[currentPoint.I + 1][currentPoint.J] ==1 )
                    {
                        grid[currentPoint.I + 1][currentPoint.J] = 2;
                        queue.Enqueue((currentPoint.I + 1, currentPoint.J));
                        totalFresh--;
                    }
                    if (currentPoint.I - 1 >= 0 && grid[currentPoint.I - 1][currentPoint.J] ==1 )
                    {
                        grid[currentPoint.I - 1][currentPoint.J] = 2;
                        queue.Enqueue((currentPoint.I - 1, currentPoint.J));
                        totalFresh--;
                    }
                    if (currentPoint.J - 1 >= 0 && grid[currentPoint.I][currentPoint.J - 1] ==1 )
                    {
                        grid[currentPoint.I][currentPoint.J - 1] = 2;
                        queue.Enqueue((currentPoint.I, currentPoint.J - 1));
                        totalFresh--;
                    }
                    if (currentPoint.J + 1 < maxJ && grid[currentPoint.I][currentPoint.J+1] ==1 )
                    {
                        grid[currentPoint.I][currentPoint.J + 1] = 2;
                        queue.Enqueue((currentPoint.I, currentPoint.J + 1));
                        totalFresh--;
                    }
                }

                currentLength = queue.Count;
            }

            if (totalFresh > 0)
            {
                return -1;
            }
            
            return minute;


        }
        
    }
}