using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class SpiralMatrixSolution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return null;
            }

            int height = matrix.Length;
            int width = matrix[0].Length;
            int minRow = 0;
            int maxRow = height - 1;
            int minCol = 0;
            int maxCol = width - 1;
            int currentRow = 0;
            int currentCol = 0;
            bool isRow = true;
            bool rowOrder = true;
            bool colOrder = true;
            IList<int> result = new List<int>();
            int total = height * width;
            while (result.Count < total)
            {
                if (isRow)
                {
                    int i = currentCol;
                    while (i >= minCol && i <= maxCol)
                    {
                        result.Add(matrix[currentRow][i]);
                        if (colOrder)
                        {
                            i++;
                        }
                        else
                        {
                            i--;
                        }
                    }

                    if (colOrder)
                    {
                        rowOrder = true;
                        minRow++;
                        currentCol = maxCol;
                        currentRow = minRow;
                    }
                    else
                    {
                        rowOrder = false;
                        maxRow--;
                        currentCol = minCol;
                        currentRow = maxRow;
                    }

                    isRow = false;
                }
                else
                {
                    int j = currentRow;
                    while (j >= minRow && j <= maxRow)
                    {
                        result.Add(matrix[j][currentCol]);
                        if (rowOrder)
                        {
                            j++;
                        }
                        else
                        {
                            j--;
                        }
                    }

                    if (rowOrder)
                    {
                        colOrder = false;
                        maxCol--;
                        currentRow = maxRow;
                        currentCol = maxCol;
                    }
                    else
                    {
                        colOrder = true;
                        minCol++;
                        currentCol = minCol;
                        currentRow = minRow;
                    }

                    isRow = true;
                }
            }

            return result;
        }

        public IList<int> SpiralOrder2(int[][] matrix)
        {
            var result = new List<int>();
            if (matrix.Length == 0)
            {
                return result;
            }

            int upperRow = matrix.Length - 1;
            int lowerRow = 0;
            int upperCol = matrix[0].Length - 1;
            int lowerCol = 0;

            int row = 0;
            int col = 0;
            bool rowOrder = true; //left to right
            bool colOrder = true; //top to bottom
            bool isRow = true;

            int total = matrix.Length * matrix[0].Length;
            while (total > 0)
            {
                if (isRow)
                {
                    if (rowOrder)
                    {
                        for (int i = lowerCol; i <= upperCol; i++)
                        {
                            result.Add(matrix[row][i]);
                        }

                        colOrder = true;
                        upperRow--;
                        row = upperRow;
                        col = lowerCol;
                    }
                    else
                    {
                        for (int i = upperCol; i >= lowerCol; i--)
                        {
                            result.Add(matrix[row][i]);
                        }

                        colOrder = false;
                        lowerRow++;
                        row = lowerRow;
                        col = upperCol;
                    }

                    isRow = false;
                }
                else
                {
                    if (colOrder)
                    {
                        for (int i = lowerRow; i <= upperRow; i++)
                        {
                            result.Add(matrix[col][i]);
                        }

                        rowOrder = false;
                        upperCol--;
                        col = upperCol;
                        row = upperRow;
                    }
                    else
                    {
                        for (int i = upperCol; i >= lowerCol; i--)
                        {
                            result.Add(matrix[row][i]);
                        }

                        rowOrder = true;
                        colOrder = false;
                        lowerRow++;
                        row = lowerRow;
                        col = upperCol;
                    }
                }
            }

            return result;
        }
    }
}