using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class LongestConsecutiveSequenceSolution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numsSet = new HashSet<int>();
            foreach (var i in nums)
            {
                numsSet.Add(i);
            }

            int longestStreak = 0;
            foreach (var i in numsSet)
            {
                if (!numsSet.Contains(i - 1)) {
                    int currentNum = i;
                    int currentStreak = 1;

                    while (numsSet.Contains(currentNum + 1)) {
                        currentNum += 1;
                        currentStreak += 1;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        public int LongestConsecutive1(int[] nums) {
            if (nums.Length <= 1)
            {
                return nums.Length;
            }
            MergeSort(nums, 0, nums.Length - 1);
            int maxLong = 0;
            int curLong = 1;
            List<int> list = new List<int>();
            foreach (var i in nums)
            {
                if (list.Contains(i))
                {
                    continue;
                }
                list.Add(i);
            }

            int prev = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] - prev == 1)
                {
                    curLong++;
                }
                else
                {
                    if (curLong > maxLong)
                    {
                        maxLong = curLong;
                    }
                    curLong = 1;
                }

                prev = list[i];
            }

            if (curLong > maxLong)
            {
                maxLong = curLong;
            }

            return maxLong;
        }


        private void MergeSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int mid = (right + left) / 2;
                MergeSort(nums, left, mid);
                MergeSort(nums, mid + 1, right);
                Merge(nums, left, mid, right);
            }
        }

        private void Merge(int[] nums, int left, int mid, int right)
        {
            int[] leftArr = new int[mid - left + 1];
            int[] rightArr = new int[right - mid];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i <= mid - left)
            {
                leftArr[i] = nums[left + i];
                i++;
            }

            while (j < right - mid)
            {
                rightArr[j] = nums[mid + j + 1];
                j++;
            }

            i = 0;
            j = 0;
            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] < rightArr[j])
                {
                    nums[k + left] = leftArr[i];
                    i++;
                }
                else
                {
                    nums[k + left] = rightArr[j];
                    j++;
                }

                k++;
            }

            while (i < leftArr.Length)
            {
                nums[k + left] = leftArr[i];
                i++;
                k++;
            }

            while (j<rightArr.Length)
            {
                nums[k + left] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}