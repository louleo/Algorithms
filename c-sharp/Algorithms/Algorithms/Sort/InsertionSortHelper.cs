namespace Algorithms.Sort
{
    public static class InsertionSortHelper
    {
        //Insertion sort - start from index 1, store it in temp value, find the correct place and then insert into.
        //compare and shift
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0)
                {
                    if (arr[j] > temp)
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }

                arr[j+1] = temp;
            }
        }
    }
}