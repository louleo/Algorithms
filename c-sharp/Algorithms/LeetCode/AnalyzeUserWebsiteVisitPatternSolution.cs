using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Xml.Xsl;

namespace LeetCode
{
    public class VisitPattern
    {
        public IList<string> Pattern { get; set; }
        
        public int Count { get; set; }

        public VisitPattern((string, string, string) pattern, int count)
        {
            Pattern = new List<string>()
            {
                pattern.Item1,
                pattern.Item2,
                pattern.Item3
            };
            Count = count;
        }

        public int CompareTo(VisitPattern other)
        {
            if (this.Count == other.Count)
            {
                for (int i = 0; i < Pattern.Count; i++)
                {
                    if (String.Compare(this.Pattern[i], other.Pattern[i]) != 0)
                    {
                        return String.Compare(this.Pattern[i], other.Pattern[i]);
                    }
                }

                return 0;
            }

            return other.Count - this.Count;
        }
    }

    public class UserRoutine
    {
        public string Website { get; set; }

        public int Timestamp
        {
            get; set;
        }

        public UserRoutine(string website, int timestamp)
        {
            Website = website;
            Timestamp = timestamp;
        }
    }
    
    public class AnalyzeUserWebsiteVisitPatternSolution
    {
        public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website) {
            Dictionary<string, List<UserRoutine>> userRoutes = new Dictionary<string, List<UserRoutine>> ();
            for(int i = 0; i < username.Length; i ++){
                List<UserRoutine> value;
                if(userRoutes.TryGetValue(username[i], out value)){
                    value.Add(new UserRoutine(website[i], timestamp[i]));
                }else{
                    value = new List<UserRoutine>();
                    value.Add(new UserRoutine(website[i], timestamp[i]));
                    userRoutes.Add(username[i], value);
                }
            }

            Dictionary<(string, string, string), int> patternCounts = new Dictionary<(string, string, string), int>();
            foreach(List<UserRoutine> routines in userRoutes.Values)
            {
                routines.Sort((UserRoutine left, UserRoutine right) => (left.Timestamp - right.Timestamp));
                HashSet<(string, string, string)> userPatterns = new HashSet<(string, string, string)>();
                for(int i = 0; i < routines.Count - 2; i ++){
                    for(int j = i + 1; j < routines.Count - 1; j ++){
                        for(int k = j + 1; k < routines.Count; k ++){
                            var pattern = (routines[i].Website, routines[j].Website, routines[k].Website);
                            if (userPatterns.Contains(pattern))
                            {
                                continue;
                            }
                            var patternCount = 1;
                            if(patternCounts.TryGetValue(pattern, out patternCount)){
                                patternCounts[pattern] = (patternCount + 1);
                            }else{
                                patternCounts.Add(pattern, 1);
                            }

                            userPatterns.Add(pattern);
                        }
                    }
                }
            }

            List<VisitPattern> list = new List<VisitPattern>();
            foreach (var pair in patternCounts)
            {
                list.Add(new VisitPattern(pair.Key, pair.Value));
            }
            
            list.Sort((VisitPattern left, VisitPattern right) => (left.CompareTo(right)));

            var result = list[0].Pattern;
            return result;
        }
    }
}