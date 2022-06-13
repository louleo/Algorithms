using System.Collections.Generic;

namespace LeetCode.HashMaps
{
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int len = s.Length;
            char prevChar = s[len-1];
            int ans = 0;
            int current = len - 1;
            while(current >= 0)
            {
                if (dict[s[current]] < dict[prevChar])
                {
                    ans -= dict[s[current]];
                }
                else
                {
                    ans += dict[s[current]];
                }

                prevChar = s[current];
                current--;
            }

            return ans;
        }
    }
}