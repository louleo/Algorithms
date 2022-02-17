using System;

namespace LeetCode
{
    public class MultiplyStringsSolution
    {
        public string Multiply(string num1, string num2) {
            if (num1[0] == '0' || num2[0] == '0')
            {
                return "0";
            }

            long ans = 0;            

            for (int i = num1.Length - 1; i > -1; i--)
            {
                for (int j = num2.Length - 1; j > -1; j--)
                {
                    int current = Int32.Parse(num1[i].ToString())*Int32.Parse(num2[j].ToString());
                    ans += (current * (long)Math.Pow(10, num1.Length - i - 1) * (long)Math.Pow(10, num2.Length - j - 1));
                }
            }
            

            return ans.ToString();
        }
    }
}