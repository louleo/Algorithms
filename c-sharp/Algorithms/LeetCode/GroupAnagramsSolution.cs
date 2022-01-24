using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LeetCode
{
    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            IList<IList<string>> results = new List<IList<string>>();
            foreach (var str in strs)
            {
                string newStr = String.Concat(str.OrderBy(a => a));
                IList<string> list;
                if (dict.TryGetValue(newStr, out list))
                {
                    list.Add(str);
                }
                else
                {
                    dict[newStr] = new List<string>();
                    dict[newStr].Add(str);
                }
            }

            foreach (var pair in dict)
            {
                results.Add(pair.Value);
            }

            return results;
        }
    }
}