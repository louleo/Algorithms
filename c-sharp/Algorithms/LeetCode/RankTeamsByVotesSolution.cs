using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class VoteRecord
    {
        public char TeamName;
        public int[] VotesPerPosition;

        public VoteRecord(char teamName, int numberOfTeams)
        {
            TeamName = teamName;
            VotesPerPosition = new int[numberOfTeams];
        }

        public bool IsBiggerThan(VoteRecord anotherRecord)
        {
            int i = 0;
            int j = 0;
            while (i < VotesPerPosition.Length && j < anotherRecord.VotesPerPosition.Length)
            {
                if (VotesPerPosition[i] > anotherRecord.VotesPerPosition[j])
                {
                    return true;
                }
                else if(VotesPerPosition[i] < anotherRecord.VotesPerPosition[j])
                {
                    return false;
                }

                i++;
                j++;
            }

            if (VotesPerPosition.Length == anotherRecord.VotesPerPosition.Length)
            {
                return TeamName < anotherRecord.TeamName;
            }
            
            return VotesPerPosition.Length > anotherRecord.VotesPerPosition.Length;
        }
        
    }
    
    public class RankTeamsByVotesSolution
    {
        
        
        public string RankTeams(string[] votes)
        {
            Dictionary<char, VoteRecord> voteRecords = new Dictionary<char, VoteRecord>();
            int numberOfTeams = votes[0].Length;
            
            for (int i = 0; i < votes.Length; i++)
            {
                for(int j = 0; j < votes[i].Length; j ++)
                {
                    VoteRecord voteCount;
                    if (voteRecords.TryGetValue(votes[i][j], out voteCount))
                    {
                        voteCount.VotesPerPosition[j] += 1;
                        voteRecords[votes[i][j]] = voteCount;
                    }
                    else
                    {
                        voteCount = new VoteRecord(votes[i][j], numberOfTeams);
                        voteCount.VotesPerPosition[j] += 1;
                        voteRecords.Add(votes[i][j], voteCount);
                    }
                }
            }

            List<VoteRecord> voteRecordArr = voteRecords.Values.ToList();
            
            SortVoteRecordList(voteRecordArr, 0, voteRecordArr.Count - 1);

            StringBuilder rankingResults = new StringBuilder();

            foreach (var record in voteRecordArr)
            {
                rankingResults.Append(record.TeamName.ToString());
            }

            return rankingResults.ToString();
        }

        public void SortVoteRecordList(List<VoteRecord> voteRecords, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;
                SortVoteRecordList(voteRecords, leftIndex, midIndex);
                SortVoteRecordList(voteRecords, midIndex + 1, rightIndex);
                SortVoteRecordListMerge(voteRecords, leftIndex, midIndex, rightIndex);
            }
        }

        public void SortVoteRecordListMerge(List<VoteRecord> voteRecords, int leftIndex, int midIndex, int rightIndex)
        {
            int i;
            int j;

            List<VoteRecord> leftList = new List<VoteRecord>();
            List<VoteRecord> rightList = new List<VoteRecord>();

            for (i = leftIndex; i <= midIndex; i++)
            {
                leftList.Add(voteRecords[i]);
            }            
            
            for (j = midIndex + 1; j <= rightIndex; j++)
            {
                rightList.Add(voteRecords[j]);
            }

            i = 0;
            j = 0;
            int k = leftIndex;
            while (i < leftList.Count && j < rightList.Count)
            {
                bool result = leftList[i].IsBiggerThan(rightList[j]);
                if (leftList[i].IsBiggerThan(rightList[j]))
                {
                    voteRecords[k] = leftList[i];
                    i++;
                }
                else
                {
                    voteRecords[k] = rightList[j];
                    j++;
                }

                k++;
            }

            while (i < leftList.Count)
            {
                voteRecords[k] = leftList[i];
                i++;
                k++;
            }
            
            while (j < rightList.Count)
            {
                voteRecords[k] = rightList[j];
                j++;
                k++;
            }
        }
    }
}