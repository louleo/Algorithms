using System.Collections.Generic;

namespace LeetCode.Arrays
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length < 2)
            {
                return;
            }
            int pointer1 = 0;
            int pointer2 = 1;
            while (pointer1 < nums.Length && pointer2 < nums.Length)
            {
                if (nums[pointer1] == 0 && nums[pointer2] != 0)
                {
                    (nums[pointer1], nums[pointer2]) = (nums[pointer2], nums[pointer1]);
                    pointer1++;
                    pointer2 = pointer1 + 1;
                }

                if (nums[pointer1] != 0 && nums[pointer2] != 0)
                {
                    pointer1++;
                    pointer2 = pointer1 + 1;
                }

                if (nums[pointer1] == 0 && nums[pointer2] == 0)
                {
                    pointer2++;
                }
            }
        }
        
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<char> setColumn = new HashSet<char>();
            HashSet<char> setRow = new HashSet<char>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (setRow.Contains(board[i][j]))
                        {
                            return false;
                        }

                        setRow.Add(board[i][j]);
                    }

                    if (board[j][i]!='.')
                    {
                        if (setColumn.Contains(board[j][i]))
                        {
                            return false;
                        }

                        setColumn.Add(board[j][i]);
                    }
                }
                setColumn.Clear();
                setRow.Clear();
            }

            HashSet<char> setBlock = new HashSet<char>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (board[i*3 + k][j*3+k]!='.')
                        {
                            if (setBlock.Contains(board[i*3 + k][j*3+k]))
                            {
                                return false;
                            }

                            setBlock.Add(board[i * 3 + k][j * 3 + k]);
                        }
                        
                        if (board[j*3 + k][i*3+k]!='.')
                        {
                            if (setBlock.Contains(board[j*3 + k][i*3+k]))
                            {
                                return false;
                            }

                            setBlock.Add(board[j * 3 + k][i * 3 + k]);
                        }
                    }
                    setBlock.Clear();
                }
                
            }

            return true;
        }    
    }
}