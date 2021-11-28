using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    
    /*
     * left 3 right 0
     * (()())
     * ((()))
     * left 2 right 1
     * ()()()/(())()
     * left 1 right 2
     * ()(())
    */
    public class GenerateParenthesesSolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            HashSet<string> results = new HashSet<string>();
            if (n == 1)
            {
                results.Add("()");
            }
            else if (n > 1)
            {
                int innerN = n - 1;
                var subResults = GenerateParenthesis(innerN);
                foreach (var str in subResults)
                {
                    results.Add("(" + str + ")");
                }

                while (innerN > 0)
                {
                    int left = n - innerN;
                    int right = innerN;
                    var subLeft = GenerateParenthesis(left);
                    var subRight = GenerateParenthesis(right);
                    foreach (var leftStr in subLeft)
                    {
                        foreach (var rightStr in subRight)
                        {
                            results.Add(leftStr + rightStr);
                        }
                    }

                    innerN--;
                }
            }

            return results.ToList();
        }
    }
}

