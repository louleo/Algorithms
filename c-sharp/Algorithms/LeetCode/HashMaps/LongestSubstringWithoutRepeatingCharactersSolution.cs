using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashMaps
{

    public class CharData
    {
        public int Length { get; set; }
        public int Index { get; set; }

        public CharData(int index, int length)
        {
            Index = index;
            Length = length;
        }
    }
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            
            if(s.Length <= 1){
                return s.Length;
            }

            Dictionary<char, CharData> dict = new Dictionary<char, CharData>();

            //Hashmap to store char - index mapping
            
            
            /*
             * iterate char in string s
             * if find duplicate, then update max length and update dictionary as well
             */

            int maxLength = 0;
            int length;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    length = Math.Min((i - dict[s[i]].Index), (i == 0 ? 1: dict[s[i-1]].Length+1));
                    dict[s[i]].Index = i;
                    dict[s[i]].Length = length;
                }
                else
                {
                    length = i == 0 ? 1 : dict[s[i - 1]].Length + 1;
                    dict.TryAdd(s[i], new CharData(i, length));
                }
                maxLength = Math.Max(maxLength, length);
            }

            return maxLength;
        }
    }
}