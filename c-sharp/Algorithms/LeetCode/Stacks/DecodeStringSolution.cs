using System;
using System.Collections.Generic;

namespace LeetCode.Stacks
{
    public class DecodeStringSolution
    {
        public string DecodeString(string s)
        {
            Stack<char> stack = new Stack<char>();
            Stack<string> stackStr = new Stack<string>();
            int index = 0;
            int length = s.Length;
            string res = "";
            string current;
            string integer;
            string single;
            while (index < length)
            {
                if (s[index] == ']')
                {
                    if (s[index - 1] == ']')
                    {
                        single = stackStr.Pop();
                    }
                    else
                    {
                        single = "";
                    }
                    integer = "";
                    current = "";
                    while (stack.Peek() != '[')
                    {
                        single = stack.Pop() + single;
                    }
                    stack.Pop();
                    while (stack.Count > 0 && Char.IsDigit(stack.Peek()))
                    {
                        integer = stack.Pop() + integer;
                    }
                    int count = Int32.Parse(integer);
                    while (count > 0)
                    {
                        current += single;
                        count--;
                    }
                    stackStr.Push(current);
                }
                else
                {
                    if (Char.IsDigit(s[index]))
                    {
                        current = "";
                        while (stack.Count != 0)
                        {
                            current = stack.Pop() + current;
                        }
                        stackStr.Push(current);
                    }
                    stack.Push(s[index]);
                }
                index++;
            }

            current = "";
            while (stack.Count != 0)
            {
                current = stack.Pop() + current;
            }
            stackStr.Push(current);

            while (stackStr.Count != 0)
            {
                res = stackStr.Pop() + res;
            }

            return res;
        }
    }
}