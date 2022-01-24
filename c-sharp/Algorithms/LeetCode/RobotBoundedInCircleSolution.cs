using System.Collections.Generic;

namespace LeetCode
{
    public class RobotBoundedInCircleSolution
    {
        public bool IsRobotBounded(string instructions)
        {
            
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict['L'] = 0;
            dict['R'] = 0;
            
            foreach (var c in instructions)
            {
                int count;
                if (dict.TryGetValue(c, out count))
                {
                    dict[c] += 1;
                }
                else
                {
                    dict.Add(c,1);
                }
            }

            return dict['L'] != dict['R'];
        }
    }
}