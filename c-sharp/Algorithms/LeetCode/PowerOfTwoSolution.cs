using System;
using System.IO.Compression;
using Microsoft.VisualBasic.CompilerServices;

namespace LeetCode
{
    public class PowerOfTwoSolution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0)
            {
                return false;
            }

            if (n == 1)
            {
                return true;
            }

            if (n == Int32.MinValue)
            {
                return true;
            }

            if (n < 0)
            {
                n = -n;
            }
            
            var value = Convert.ToString(n, 2);

            value = value.Substring(1);

            return Convert.ToInt32(value, 2) == 0;
            
        }
        
        public bool IsPowerOfTwo2(int n) {
            if (n <= 0)
            {
                return false;
            }

            while (n % 2 == 0)
            {
                n = n / 2;
            }

            return n == 1;
        }
    }
}