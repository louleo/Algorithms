using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace DataStructure
{
    public class MaxHeap
    {
        private List<int> _heap;
        private int _heapSize;

        public MaxHeap()
        {
            _heap = new List<int>();
        }

        public MaxHeap(int[] arr)
        {
            _heap = arr.ToList();
            _heapSize = arr.Length;
            BuildMaxHeap();
        }

        public void Insert(int element)
        {
            _heapSize += 1;
            _heap[_heapSize] = element;
            BuildMaxHeap();
        }

        public int Search(int element)
        {
            int index = 0;
            int heapSize = HeapSize();
            while (index < heapSize)
            {
                if (element == _heap[index])
                {
                    return index;
                }

                index++;
            }
            return -1;
        }

        public void Delete(int element)
        {
            if (_heapSize <= 0)
            {
                return;
            }
            int index = Search(element);
            if (index >= 0)
            {
                (_heap[index], _heap[_heapSize - 1]) = (_heap[_heapSize - 1], _heap[index]);
                _heapSize -= 1;
                BuildMaxHeap();
            }
            
        }

        private void BuildMaxHeap()
        {
            int heapSize = HeapSize();
            for (int i = heapSize/2; i >= 0; i--)
            {
                MaxHeapify(i);
            }
        }

        private void MaxHeapify(int index)
        {
            if (index > HeapSize())
            {
                throw new StackOverflowException();
            }

            int leftIndex = Left(index);
            int rightIndex = Right(index);
            int heapSize = HeapSize();
            int largestIndex = index;

            if (rightIndex < heapSize && _heap[rightIndex] > _heap[largestIndex])
            {
                largestIndex = rightIndex;
            }
            
            if (leftIndex < heapSize && _heap[leftIndex] > _heap[largestIndex])
            {
                largestIndex = leftIndex;
            }

            if (largestIndex != index)
            {
                (_heap[index], _heap[largestIndex]) = (_heap[largestIndex], _heap[index]);
                MaxHeapify(largestIndex);
            }
        }


        private int Parent(int index)
        {
            return index / 2;
        }

        private int Left(int index)
        {
            return 2 * index;
        }

        private int Right(int index)
        {
            return 2 * index + 1;
        }

        private int HeapSize()
        {
            return _heapSize;
        }
    }
}