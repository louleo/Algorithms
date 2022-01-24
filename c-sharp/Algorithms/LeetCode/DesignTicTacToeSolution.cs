namespace LeetCode
{

    namespace DesignTicTacToe
    {
        public class TicTacToe
        {

            private int[,] _arr;
            private int _cap;

            public TicTacToe(int n) {
                _arr = new int[n,n];
                _cap = n;
            }
    
            public int Move(int row, int col, int player)
            {
                _arr[row, col] = player;
                if (CheckCol(col, player) || CheckRow(row,player) || CheckDia(row, col, player))
                {
                    return player;
                }

                return 0;

            }

            private bool CheckRow(int row, int player)
            {
                for (int i = 0; i < _cap; i++)
                {
                    if (_arr[row, i] != player)
                    {
                        return false;
                    }
                }

                return true;
            }

            private bool CheckCol(int col, int player)
            {
                for (int i = 0; i < _cap; i++)
                {
                    if (_arr[i, col] != player)
                    {
                        return false;
                    }
                }

                return true;
            }

            private bool CheckDia(int row, int col, int player)
            {
                
                if (row == col)
                {
                    int i;
                    for (i = 0; i < _cap; i++)
                    {
                        if (_arr[i,i] != player)
                        {
                            break;
                        } 
                    }

                    if (i >= _cap)
                    {
                        return true;
                    }
                }

                
                if (row == (_cap - col - 1))
                {
                    int j;
                    for (j = 0; j < _cap; j++)
                    {
                        if (_arr[j,_cap - j - 1] != player)
                        {
                            break;
                        }
                    }

                    if (j >= _cap)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }

}