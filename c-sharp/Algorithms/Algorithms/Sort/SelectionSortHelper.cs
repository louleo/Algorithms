namespace Algorithms.Sort
{
    public static class SelectionSortHelper
    {
        //Selection sort - reverse bubble sort
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smallestIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[smallestIndex] > arr[j])
                    {
                        smallestIndex = j;
                    }
                }

                (arr[i], arr[smallestIndex]) = (arr[smallestIndex], arr[i]);
            }
        }
    }
}