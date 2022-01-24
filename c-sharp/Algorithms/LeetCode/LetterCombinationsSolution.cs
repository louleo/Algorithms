using System.Collections.Generic;

namespace LeetCode
{
    public class LetterCombinationsSolution
    {
        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>()
            {
                {'2', "abc"},
                {'3', "def" },
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"},
            };

            IList<string> result = new List<string>();
            foreach (var c in digits)
            {
                IList<string> newResult = new List<string>();
                string letters = dict[c];
                foreach (var letter in letters)
                {
                    if (result.Count == 0)
                    {
                        newResult.Add(letter.ToString());
                    }
                    else
                    {
                        foreach (var str in result)
                        {
                            newResult.Add(str + letter);
                        }
                    }
                }

                result = newResult;
            }

            return result;
        }
    }
}