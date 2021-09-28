using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Algorithms.Sort
{
    public class MergeSortHelper: ISortHelper
    {
        public void SortArray(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }
            MergeSort(arr, 0, arr.Length - 1);
        }

        private void MergeSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middle = (leftIndex + rightIndex) / 2;
                MergeSort(arr, leftIndex, middle);
                MergeSort(arr, middle+1, rightIndex);
                Merge(arr, leftIndex, middle, rightIndex);
            }
        }

        private void Merge(int[] arr, int leftIndex, int middle, int rightIndex)
        {
            int leftArrLength = middle - leftIndex + 1;
            int rightArrLength = rightIndex - middle;
            
            int left = 0;
            int right = 0;

            int[] leftArr = new int[leftArrLength];
            int[] rightArr = new int[rightArrLength];
            
            for (int i = 0; i < leftArrLength; i++)
            {
                leftArr[i] = arr[i + leftIndex];
            }

            for (int j = 0; j < rightArrLength; j++)
            {
                rightArr[j] = arr[middle + j + 1];
            }

            int t = leftIndex;
            while (left < leftArr.Length && right < rightArr.Length)
            {
                if (leftArr[left] < rightArr[right])
                {
                    arr[t] = leftArr[left];
                    left++;
                }
                else
                {
                    arr[t] = rightArr[right];
                    right++;
                }

                t++;
            }

            while (left < leftArr.Length)
            {
                arr[t] = leftArr[left];
                left++;
                t++;
            }

            while (right < rightArr.Length)
            {
                arr[t] = rightArr[right];
                right++;
                t++;
            }
        }
    }
}