using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ReorderDataInLogFilesSolution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            List<string> letterLogs = new List<string>();
            List<string> digitLogs = new List<string>();

            foreach(var log in logs){
                string[] split = log.Split(" ",2);
                if(Char.IsDigit(split[1][0])){
                    digitLogs.Add(log);
                }else{
                    letterLogs.Add(log);
                }
            }

            letterLogs.Sort((log1, log2)=>{
                string[] split1 = log1.Split(" ",2);
                string[] split2 = log2.Split(" ",2);
                int cmp = split1[1].CompareTo(split2[1]);
                if (cmp == 0)
                {
                    return split1[0].CompareTo(split2[0]);
                }
                else
                {
                    return cmp;
                }
            });

            letterLogs.AddRange(digitLogs);

            return letterLogs.ToArray();
        }

    }
}