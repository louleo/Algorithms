using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class MostCommonWordSolution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            char[] separateChars = new[]
            {
                ' ', '!', '?', ',' ,'\'', ';', '.'
            };
            paragraph = paragraph.ToLower();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string word = String.Empty;
            int count;
            int maxCount = 0;
            string maxWord = "";
            foreach (var c in paragraph)
            {
                if (separateChars.Contains(c))
                {
                    if (!String.IsNullOrEmpty(word) && !banned.Contains(word))
                    {
                        if (dict.TryGetValue(word, out count))
                        {
                            dict[word] += 1;
                        }
                        else
                        {
                            dict.Add(word, 1);
                        }
                        if (maxCount < dict[word])
                        {
                            maxWord = word;
                            maxCount = dict[word];
                        }
                    }

                    word = String.Empty;
                }
                else
                {
                    word += c;
                }
            }

            if (!String.IsNullOrEmpty(word) && !banned.Contains(word))
            {
                if (dict.TryGetValue(word, out count))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
                if (maxCount < dict[word])
                {
                    maxWord = word;
                    maxCount = dict[word];
                }
            }
            return maxWord;
        }
    }
}