using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace LeetCode
{
    
    public class WordLadderSolution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
            if (!wordList.Contains(endWord))
            {
                return 0;
            }
            
            wordList.ToList().Sort((word1, word2) =>
            {
                int word1Diff = SingleCharDiff(word1, endWord);
                int word2Diff = SingleCharDiff(word2, endWord);
                return word2Diff - word1Diff;
            });
            
            int ans = LadderLength(beginWord, endWord, wordList, wordList.Count - 1);
            if (ans != 0)
            {
                return ans + 1;
            }
            else
            {
                return 0;
            }
            
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList, int startIndex)
        {
            string newBeginWord = String.Empty;
            for (int i = startIndex; i >= 0; i--)
            {
                if (SingleCharDiff(wordList[i], beginWord) == 1)
                {
                    newBeginWord = wordList[i];
                    startIndex = i - 1;
                }
            }

            if (startIndex < 0)
            {
                return 1;
            }
            
            if (String.IsNullOrEmpty(newBeginWord))
            {
                return 0;
            }
            
            int ans = LadderLength(newBeginWord, endWord, wordList, startIndex);
            
            if (ans != 0)
            {
                return ans + 1;
            }
            else
            {
                return 0;
            }
        }

        private int SingleCharDiff(string word1, string word2)
        {
            int diff = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] != word2[i])
                {
                    diff++;
                }
            }

            return diff;
        }
        
        
    }
}