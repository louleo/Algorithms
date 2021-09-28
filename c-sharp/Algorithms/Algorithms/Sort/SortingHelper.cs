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

            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j > 0 && arr[j] > key)
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right / 2);
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
            int leftArrLength = mid - left + 1;
            int rightArrLength = right - mid;

            int[] leftArr = new int[leftArrLength];
            int[] rightArr = new int[rightArrLength];
            int i, j;
            for (i = 0; i < leftArrLength; i++)
            {
                leftArr[i] = arr[left + i];
            }

            for (j = 0; j < rightArrLength; j++)
            {
                rightArr[j] = arr[mid + j + 1];
            }

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrLength && j < rightArrLength)
            {
                if (leftArr[i] < rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }

                k++;
            }


            while (i < leftArrLength)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < rightArrLength)
            {
                arr[k] = rightArr[j];
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

                int k = left - 1;
                
                for (int i = left; i < pivotIndex; i++)
                {
                    if (arr[i] < pivot)
                    {
                        k++;
                        (arr[k], arr[i]) = (arr[i], arr[k]);
                    }
                }

                (arr[k + 1], arr[pivotIndex]) = (arr[pivotIndex], arr[k + 1]);

                pivotIndex = k + 1;
                QuickSort(arr, left, pivotIndex-1);
                QuickSort(arr, pivotIndex+1, right);
            }
        } 
        
        
    }
}