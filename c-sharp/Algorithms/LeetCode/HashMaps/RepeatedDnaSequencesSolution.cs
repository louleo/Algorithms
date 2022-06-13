using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashMaps
{
    public class RepeatedDnaSequencesSolution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> ans = new HashSet<string>();
            if (s.Length < 10)
            {
                return ans.ToList();
            }

            HashSet<string> set = new HashSet<string>();
            int index = 0;
            string substr;
            while (index + 10 <= s.Length)
            {
                substr = s.Substring(index, 10);
                if (set.Contains(substr))
                {
                    ans.Add(substr);
                }
                else
                {
                    set.Add(substr);
                }

                index++;
            }

            return ans.ToList();
        }
    }
}