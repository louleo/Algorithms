from typing import List


class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        return self.lengthOfLongestSubstring1(s)

    def lengthOfLongestSubstring1(self, s: str)-> int:
        n = len(s)
        ans = 0
        # mp stores the current index of a character
        mp = {}

        i = 0
        # try to extend the range [i, j]
        for j in range(n):
            if s[j] in mp:
                i = max(mp[s[j]], i)

            ans = max(ans, j - i + 1)
            mp[s[j]] = j + 1

        return ans


def runTests():
    solution = Solution()

    s = "abcabcbb"
    output = 3

    print(output == solution.lengthOfLongestSubstring(s))

    s = "bbbbb"
    output = 1

    print(output == solution.lengthOfLongestSubstring(s))

    s = "pwwkew"
    output = 3

    print(output == solution.lengthOfLongestSubstring(s))


    s = ""
    output = 0

    print(output == solution.lengthOfLongestSubstring(s))


