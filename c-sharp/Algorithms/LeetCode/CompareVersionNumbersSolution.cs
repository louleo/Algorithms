using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class CompareVersionNumbersSolution
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] v1List = version1.Split('.');
            string[] v2List = version2.Split('.');

            int v1Ptr = 0;
            int v2Ptr = 0;
            int v1Len = v1List.Length;
            int v2Len = v2List.Length;
            
            while (v1Ptr < v1Len && v2Ptr < v2Len)
            {
                int currentV1 = Int32.Parse(v1List[v1Ptr]);
                int currentV2 = Int32.Parse(v2List[v2Ptr]);
                if (currentV1 > currentV2)
                {
                    return 1;
                }else if (currentV1 < currentV2)
                {
                    return -1;
                }

                v1Ptr++;
                v2Ptr++;
            }

            while (v1Ptr < v1Len)
            {
                int currentV1 = Int32.Parse(v1List[v1Ptr]);
                if (currentV1 != 0)
                {
                    return 1;
                }

                v1Ptr++;
            }
            
            while (v2Ptr < v2Len)
            {
                int currentV2 = Int32.Parse(v2List[v2Ptr]);
                if (currentV2 != 0)
                {
                    return -1;
                }

                v2Ptr++;
            }

            return 0;
        }
    }
}