using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeetCode
{
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            IDictionary<char, int> cache = new Dictionary<char, int>();
            cache.Add('I', 1);
            cache.Add('V', 5);
            cache.Add('X',10);
            cache.Add('L',50);
            cache.Add('C',100);
            cache.Add('D',500);
            cache.Add('M',1000);
            
            int result = 0;

            int i = s.Length - 1;
            char prev = s[i];
            do
            {
                char current = s[i];
                if (cache[current] < cache[prev])
                {
                    result -= cache[current];
                }
                else
                {
                    result += cache[current];
                }
                i--;
                prev = current;
            } while (i >= 0);

            return result;
        }
    }
}