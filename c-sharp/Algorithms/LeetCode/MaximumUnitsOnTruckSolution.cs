using System;
using System.Collections.Generic;
using System.Xml.Xsl;

namespace LeetCode
{
    public class MaximumUnitsOnTruckSolution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize) {
            Array.Sort(boxTypes, (int[] left, int[] right) =>
            {
                return right[1] - left[1];
            });

            int maxUnits = 0;
            int length = boxTypes.Length;
            int index = 0;
            while (truckSize > 0 && index < length)
            {
                if (truckSize < boxTypes[index][0])
                {
                    maxUnits += (truckSize*boxTypes[index][1]);
                    truckSize -= truckSize;
                }
                else
                {
                    maxUnits += (boxTypes[index][0] * boxTypes[index][1]);
                    truckSize -= boxTypes[index][0];
                    index++;
                }
            }
            
            return maxUnits;
        }
    }
}