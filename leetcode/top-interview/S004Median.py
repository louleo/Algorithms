from typing import List
import math


class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        return self.findMedianSortedArrays1(nums1, nums2)

    def findMedianSortedArrays1(self, nums1:List[int], nums2: List[int]) -> float:
        nums = nums1 + nums2
        nums.sort()
        isOdd = len(nums) % 2
        if isOdd:
            mid = (len(nums) + 1)/2
            return nums[int(mid)-1]
        else:
            mid = int(len(nums)/2)
            if mid > 0:
                return (nums[mid - 1] + nums[mid])/2
            else:
                return nums[mid]




def runTests():
    solution = Solution()
    nums1 = [1, 3]
    nums2 = [2]
    output = 2

    print(output == solution.findMedianSortedArrays(nums1, nums2))

    nums1 = [1,2]
    nums2 = [3,4]
    output = 2.5

    print(output == solution.findMedianSortedArrays(nums1, nums2))


    nums1 = [0,0]
    nums2 = [0,0]
    output = 0

    print(output == solution.findMedianSortedArrays(nums1, nums2))

    nums1 = []
    nums2 = [1]
    output = 1

    print(output == solution.findMedianSortedArrays(nums1, nums2))


    nums1 = [2]
    nums2 = []
    output = 2

    print(output == solution.findMedianSortedArrays(nums1, nums2))