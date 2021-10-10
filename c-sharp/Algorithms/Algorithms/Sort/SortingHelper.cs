using System.Collections.Generic;

namespace Algorithms.Sort
{
    public static class SortingHelper
    {
        public static void BubbleSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }
        }

        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid+1, right);
                Merge(arr, left, mid, right);
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        (arr[j], arr[i]) = (arr[i], arr[j]);
                    }
                }
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();
            int i, j;
            for (i = left; i <= mid; i++)
            {
                leftList.Add(arr[i]);
            }

            for (j = mid + 1; j <= right; j++)
            {
                rightList.Add(arr[j]);
            }

            i = 0;
            j = 0;
            int k = left;

            while (i < leftList.Count && j < rightList.Count)
            {
                if (leftList[i] < rightList[j])
                {
                    arr[k] = leftList[i];
                    i++;
                }
                else
                {
                    arr[k] = rightList[j];
                    j++;
                }

                k++;
            }


            while (i < leftList.Count)
            {
                arr[k] = leftList[i];
                i++;
                k++;
            }

            while (j < rightList.Count)
            {
                arr[k] = rightList[j];
                k++;
                j++;
            }
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = right;
                int pivot = arr[pivotIndex];

                int startIndex = left - 1;
                for (int i = left; i < right; i++)
                {
                    if (arr[i] < pivot)
                    {
                        startIndex += 1;
                        (arr[startIndex], arr[i]) = (arr[i], arr[startIndex]);
                    }   
                }

                startIndex += 1;
                (arr[startIndex], arr[pivotIndex]) = (arr[pivotIndex], arr[startIndex]);
                pivotIndex = startIndex;
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex+ 1, right);
            }
            
        } 
        
        
    }
}