using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class RestoreIPAddressSolution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            IList<string> result = new List<string>();
            Backtrace(result, s, string.Empty, 0, 3);
            return result;
        }

        public void Backtrace(IList<string> result, string s, string ip, int startIndex, int times)
        {
            if (times == 0)
            {
                if (IsValidIP(s.Substring(startIndex)))
                {
                    ip += '.' + s.Substring(startIndex);
                    result.Add(ip);
                }
            }

            for (int i = 1; i < 4; i++)
            {
                if (startIndex + i - 1 < s.Length)
                {
                    if (IsValidIP(s.Substring(startIndex, i)))
                    {
                        string newIp = ip;
                        if (newIp.Length != 0)
                        {
                            newIp  += '.';
                        }
                        newIp += s.Substring(startIndex, i);
                        Backtrace(result, s, newIp, startIndex+i, times-1 );
                    }
                }
            }
        }

        public bool IsValidIP(string s)
        {
            if (s.Length > 1 && s[0] == '0')
            {
                return false;
            }

            if (s.Length > 3)
            {
                return false;
            }

            if (s.Length == 0)
            {
                return false;
            }
            
            int t = Int32.Parse(s);
            return t <= 255;
        }
    }
}