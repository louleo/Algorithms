using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace LeetCode
{
    public class TopKFrequentWordsSolution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, WordDS> dict = new Dictionary<string, WordDS>();
            List<WordDS> list = new List<WordDS>();
            WordDS current;
            foreach (var word in words)
            {
                if (dict.TryGetValue(word, out current))
                {
                    current.Count += 1;
                }
                else
                {
                    current = new WordDS(word);
                    dict.Add(word, current);
                    list.Add(current);
                }
            }
            
            list.Sort((left, right) =>
            {
                if (left.Count == right.Count)
                {
                    return left.Word.CompareTo(right.Word);
                }
                else
                {
                    return right.Count - left.Count;
                }
            });

            List<string> result = new List<string>();
            for (int i = 0; i < k && i < list.Count; i++)
            {
                result.Add(list[i].Word);
            }

            return result;
        }

        
    }

    public class WordDS
    {
        public string Word;
        public int Count;

        public override bool Equals(object? obj)
        {
            return Word.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Word.GetHashCode();
        }

        public WordDS(string word)
        {
            Word = word;
            Count = 1;
        }
    }
}