

namespace Algorithms.Sort
{
    public static class BubbleSortHelper
    {
        //Bubble sort always bubbling until to the end.
        public static void Sort(int[] arr)
        {
            int sortingTimes = 0;
            while (sortingTimes < arr.Length)
            {
                int sortingActions = arr.Length - 1 - sortingTimes;
                for (int i = 0; i < sortingActions; i++)
                {
                    if (arr[i + 1] < arr[i])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    }
                }

                sortingTimes++;
            }
        }
    }
}