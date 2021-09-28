namespace Algorithms.Sort
{
    public class QuickSortHelper:ISortHelper
    {
        public void SortArray(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = right;
                int pivot = arr[pivotIndex];

                int i = left - 1;
                
                for (int k = left; k < pivotIndex; k++)
                {
                    if (arr[k] < pivot)
                    {
                        i++;
                        (arr[k], arr[i]) = (arr[i], arr[k]);
                    }
                }

                (arr[i + 1], arr[pivotIndex]) = (arr[pivotIndex], arr[i+ 1]);
                pivotIndex = i + 1;

                QuickSort(arr, left, pivotIndex-1);
                QuickSort(arr, pivotIndex+1, right);
                
            }
        }
        
    }
}