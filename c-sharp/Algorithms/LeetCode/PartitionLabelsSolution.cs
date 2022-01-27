using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class PartitionLabelsSolution
    {
        public IList<int> PartitionLabels(string s)
        {
            int[] last = new int[26];
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                last[s[i] - 'a'] = i;
            }

            List<int> partition = new List<int>();
            int end = last[s[0] - 'a'];
            int start = 0;
            for (int i = 0; i < length; i++)
            {
                if (i == end)
                {
                    partition.Add(end  - start + 1);
                    start = end + 1;
                    if (start < length)
                    {
                        end = last[s[start] - 'a'];
                    }
                }
                else
                {
                    end = Math.Max(end, last[s[i] - 'a']);
                }
            }

            return partition;
        }
    }
}