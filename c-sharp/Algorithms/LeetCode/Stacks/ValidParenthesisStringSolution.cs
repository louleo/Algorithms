using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Stacks
{
    public class ValidParenthesisStringSolution
    {
        public bool CheckValidString(string s)
        {
            Stack<int> left = new Stack<int>();
            Stack<int> stars = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    left.Push(i);
                }else if (c == '*')
                {
                    stars.Push(i);
                }
                else
                {
                    if (left.Count > 0)
                    {
                        left.Pop();
                    }else if (stars.Count > 0)
                    {
                        stars.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            while (left.Count > 0 && stars.Count >0)
            {
                if (left.Pop() > stars.Pop())
                {
                    return false;
                }
            }

            return left.Count == 0;

        }
    }
}