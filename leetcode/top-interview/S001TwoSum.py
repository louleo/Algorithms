from typing import List
from helpers import compareList


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        return self.twoSum2(nums, target)

    def twoSum1(self, nums: List[int], target: int) -> List[int]:
        if len(nums) == 2 :
            if sum(nums) == target:
                return [0,1]
        else:
            for i in range(0, len(nums) - 1):
                for j in range(i + 1, len(nums)):
                    if nums[i] + nums[j] == target:
                        return [i, j]
        return []

    def twoSum2(self, nums: List[int], target: int)-> List[int]:

        for i in range(0, len(nums)):
            diff = target - nums[i]
            try:
                j = nums.index(diff, i+1)
                if j:
                    return [i,j]
            except:
                continue
        return []


def runTests():
    testObj = Solution()

    nums1 = [2, 7, 11, 15]

    target1 = 9

    output1 = [0, 1]

    print(compareList(testObj.twoSum(nums1, target1), output1))

    nums2 = [3, 2, 4]

    target2 = 6

    output2 = [1, 2]

    print(compareList(output2, testObj.twoSum(nums2, target2)))

    nums3 = [3, 3]

    target3 = 6

    output3 = [0, 1]

    print(compareList(output3, testObj.twoSum(nums3, target3)))
