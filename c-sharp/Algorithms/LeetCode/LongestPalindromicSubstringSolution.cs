using System;

namespace LeetCode
{
    public class LongestPalindromicSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            return Solution1(s);
        }

        private string Solution1(string s)
        {

            string longestPalindrome = String.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int right = s.Length - 1;
                int left = i;

                while (right >= left)
                {
                    string subString = s.Substring(left, right - left + 1);
                    if (IsPalindromeString(subString))
                    {
                        if (subString.Length > longestPalindrome.Length)
                        {
                            longestPalindrome = subString;
                            break;
                        }
                    }

                    right--;
                }
                
                if (s.Length - i < longestPalindrome.Length)
                {
                    break;
                }
            }

            return longestPalindrome;
        }

        private bool IsPalindromeString(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}