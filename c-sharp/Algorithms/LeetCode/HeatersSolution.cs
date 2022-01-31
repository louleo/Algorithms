using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace LeetCode
{
    public class HeatersSolution
    {
        /*
         * max
         * heater to left
         * heater to right
         * heater to heater 
         */
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);
            List<int> distances = new List<int>();
            for (int i = 0; i < houses.Length; i++)
            {
                int distance = Int32.MaxValue;
                for (int j = 0; j < heaters.Length; j++)
                {
                    if (Math.Abs(heaters[j] - houses[i]) < distance)
                    {
                        distance = Math.Abs(heaters[j] - houses[i]);
                    }
                    else
                    {
                        distances.Add(distance);
                        break;
                    }

                    if (j == heaters.Length - 1)
                    {
                        distances.Add(distance);
                    }
                }
            }
            distances.Sort((left, right) => (right - left));
            return distances[0];
        }
    }
}