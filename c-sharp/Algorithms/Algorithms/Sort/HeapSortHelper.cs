using Microsoft.VisualBasic.CompilerServices;

namespace Algorithms.Sort
{
    public class HeapSortHelper: ISortHelper
    {
        public void SortArray(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            BuildMaxHeap(arr);

            for (int i = arr.Length; i >= 1; i--)
            {
                (arr[0], arr[i - 1]) = (arr[i - 1], arr[0]);
                MaxHeapify(arr, i-1, 0);
                if (arr.Length > 0)
                {
                    
                }
            }
        }

        private void BuildMaxHeap(int[] arr)
        {
            for (int i = arr.Length/2 + 1; i >= 0; i--)
            {
                MaxHeapify(arr, arr.Length, i);
            }
        }

        private void MaxHeapify(int[] arr, int heapSize, int currentNodeIndex)
        {
            int leftIndex = 2 * currentNodeIndex + 1;
            int rightIndex = 2 * (currentNodeIndex + 1);
            int largestIndex = currentNodeIndex;
            if (rightIndex < heapSize)
            {
                if (arr[rightIndex] > arr[largestIndex])
                {
                    largestIndex = rightIndex;
                }

                if (arr[leftIndex] > arr[largestIndex])
                {
                    largestIndex = leftIndex;
                }

            }else if (leftIndex < heapSize)
            {
                if (arr[leftIndex] > arr[largestIndex])
                {
                    largestIndex = leftIndex;
                }
            }

            if (largestIndex != currentNodeIndex)
            {
                (arr[largestIndex], arr[currentNodeIndex]) = (arr[currentNodeIndex], arr[largestIndex]);
                MaxHeapify(arr, heapSize, largestIndex);
            }
        }
        
        /*
         * i
         * right 2(i+1)
         * left 2i + 1
         */
    }
}