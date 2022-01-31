using System.Collections.Generic;

namespace LeetCode
{
    public class TopKFrequentElementsSolution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {

            Dictionary<int, FrequentElement> dict = new Dictionary<int, FrequentElement>();
            List<FrequentElement> list = new List<FrequentElement>();

            FrequentElement cur;
            foreach (var num in nums)
            {
                if (dict.TryGetValue(num, out cur))
                {
                    dict[num].Count += 1;
                }
                else
                {
                    cur = new FrequentElement(num);
                    dict.Add(num, cur);
                    list.Add(cur);
                }
            }
            
            list.Sort((left, right) =>
            {
                return right.Count - left.Count;
            });

            int[] ans = new int[k];
            for (int i = 0; i < k && i < list.Count; i++)
            {
                ans[i] = list[i].Value;
            }

            return ans;
        }

        public class FrequentElement
        {
            public int Value;
            public int Count;


            public FrequentElement(int value)
            {
                Value = value;
                Count = 1;
            }
        }
    }
}