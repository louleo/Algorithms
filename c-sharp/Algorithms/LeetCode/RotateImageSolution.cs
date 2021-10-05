using System.Data;

namespace LeetCode
{
    public class RotateImageSolution
    {
        public void Rotate(int[][] matrix)
        {
            RotateInternal(matrix);
        }

        private void RotateInternal(int[][] matrix)
        {
            int maxIndex = matrix.Length-1;
            for (int i = 0; i <= maxIndex/2; i++)
            {
                for (int j = 0; j <= maxIndex/2; j++)
                {
                    int temp = matrix[i][maxIndex - j];
                    matrix[i][maxIndex - j] = matrix[i][j];
                    (temp, matrix[maxIndex - i][maxIndex - j]) = (matrix[maxIndex - i][maxIndex - j], temp);
                    (temp, matrix[maxIndex - i][j]) = (matrix[maxIndex - i][j], temp);
                    matrix[i][j] = temp;
                }
            }
        }
    }
}