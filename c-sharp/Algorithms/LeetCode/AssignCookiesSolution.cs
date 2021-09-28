using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class AssignCookiesSolution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            return FindContentChildrenInternalOne(g, s);
        }

        private int FindContentChildrenInternalOne(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int numberOfChildrenContent = 0;
            int i = 0;
            int j = 0;
            while (i < g.Length && j < s.Length)
            {
                if (s[j] >= g[i])
                {
                    numberOfChildrenContent += 1;
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }

            return numberOfChildrenContent;

        }
    }
}