using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashMaps
{
    public class IntegerToRomanSolution
    {
        public string IntToRoman(int num)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "I"},
                {4, "IV"},
                {5, "V"},
                {9, "IX"},
                {10, "X"},
                {40, "XL"},
                {50, "L"},
                {90, "XC"},
                {100,  "C"},
                {400, "CD"},
                {500, "D"},
                {900, "CM"},
                {1000, "M"}
            };

            List<int> keys = dict.Keys.ToList();
            keys.Sort();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < keys.Count; i++)
            {
                stack.Push(keys[i]);
            }

            string roman = "";
            while (num > 0)
            {
                if (num >= stack.Peek())
                {
                    num -= stack.Peek();
                    roman += dict[stack.Peek()];
                }
                else
                {
                    stack.Pop();
                }
            }

            return roman;
        }
    }
}