using System.Collections.Generic;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            HashSet<char> set = new HashSet<char>();
            int longestLength = 1;
            for (int first = 0; first < s.Length; first++)
            {
                set.Clear();
                set.Add(s[first]);
                int second = first + 1;
                while (second < s.Length)
                {
                    if (set.Add(s[second]))
                    {
                        int curLength = set.Count;
                        if (curLength > longestLength)
                        {
                            longestLength = curLength;
                        }

                        second++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return longestLength;
        }
    }
}