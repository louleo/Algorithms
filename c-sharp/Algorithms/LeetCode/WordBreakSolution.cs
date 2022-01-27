using System.Collections.Generic;

namespace LeetCode
{
    public class WordBreakSolution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i < s.Length + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (wordDict.Contains(s.Substring(j, i - j)) && dp[j])
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[dp.Length - 1];
        }

        public int WordBreak(string s, IList<string> wordDict, int startIndex)
        {
            int ans = 0;
            foreach (var word in wordDict)
            {
                if (s.IndexOf(word, startIndex) == startIndex && (startIndex + word.Length) == s.Length)
                {
                    return 1;
                }else if (s.IndexOf(word, startIndex) == startIndex)
                {
                    ans += WordBreak(s, wordDict, startIndex + word.Length);
                }
            }

            return ans;
        }
    }
}