using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class NumberOfIslandsSolution
    {
        public int NumIslands(char[][] grid)
        {
            return this.BFS(grid);
        }

        private int DFS(char[][] grid)
        {
            int x = 0;
            int y = 0;
            int nums = 0;
            while (y < grid.Length)
            {
                if (grid[y][x] == '0' || grid[y][x] == '2')
                {
                    x++;
                }else if (grid[y][x] == '1')
                {
                    nums++;
                    int startI = y;
                    int startJ = x;
                    this.DFSInternal(grid, startI, startJ);
                }

                if (x >= grid[y].Length)
                {
                    x = 0;
                    y++;
                }
            }

            return nums;
        }

        private void DFSInternal(char[][] grid, int y, int x)
        {
            if (grid[y][x] == '1')
            {
                grid[y][x] = '2';
                //mark as visited
                if (x + 1 < grid[y].Length)
                {
                    DFSInternal(grid, y, x+1);
                }

                if (y + 1 < grid.Length)
                {
                    DFSInternal(grid, y+1, x);
                }

                if (x > 0)
                {
                    DFSInternal(grid, y , x-1);
                }

                if (y > 0)
                {
                    DFSInternal(grid, y-1, x);
                }
            }
        }

        private int BFS(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;
            
            int nums = 0;
            int nr = grid.Length - 1;
            int nc = grid[0].Length - 1;
            
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        nums++;
                        grid[r][c] = '0';
                        Queue<(int,int)> neighbors = new Queue<(int,int)>();
                        neighbors.Enqueue((r,c));
                        while (neighbors.Count != 0)
                        {
                            int row, col;
                            (row, col) = neighbors.Dequeue();
                            if (row > 0 && grid[row-1][col] == '1')
                            {
                                grid[row - 1][col] = '0';
                                neighbors.Enqueue((row - 1, col));
                            }else if (row < nr && grid[row+1][col] == '1')
                            {
                                neighbors.Enqueue((row + 1, col));
                                grid[row + 1][col] = '0';
                            }else if (col > 0 && grid[row][col - 1] == '1')
                            {
                                neighbors.Enqueue((row, col-1));
                                grid[row][col - 1] = '0';
                            }else if (col < nc && grid[row][col + 1] == '1')
                            {
                                neighbors.Enqueue((row, col + 1));
                                grid[row][col + 1] = '0';
                            }
                        }
                    }
                }
            }

            return nums;
        }
        
        
    }
}