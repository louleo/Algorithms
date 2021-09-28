using System;
using System.Collections.Generic;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> test = new Dictionary<int, int>();
            test.Add(1, 1);
            test.Add(2,2);
            test.Remove(1);
            int value;
            if (test.TryGetValue(1, out value))
            {
                Console.WriteLine("sss");
            }
            
            Console.WriteLine(value);
        }
    }
}