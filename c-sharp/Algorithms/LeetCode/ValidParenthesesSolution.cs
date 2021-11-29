using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var input in s)
            {
                switch (input)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(input);
                        break;
                    case '}':
                    case ']':
                    case ')':
                        char result;
                        if (stack.TryPop(out result))
                        {
                            if (result == '{' && input != '}') return false;

                            if (result == '[' && input != ']') return false;

                            if (result == '(' && input != ')') return false;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }

            }

            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}