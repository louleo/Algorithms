using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            bool isNegative = x < 0;
            if (isNegative)
            {
                x = -x;
            }

            Stack<char> stack = new Stack<char>();
            string numberStr = x.ToString();
            foreach (var c in numberStr)
            {
                stack.Push(c);
            }

            while (stack.Count > 0 && stack.Peek() == '0')
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                return 0;
            }

            if (stack.Count > 10)
            {
                return 0;
            }

            numberStr = "";
            while (stack.Count > 0)
            {
                numberStr += stack.Pop();
            }
            
            int number = Int32.Parse(numberStr);
            if (isNegative)
            {
                number = -number;
            }

            return number;
        }
    }
}