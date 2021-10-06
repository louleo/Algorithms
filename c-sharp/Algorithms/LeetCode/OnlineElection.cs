using System.Collections.Generic;

namespace LeetCode
{
    public class OnlineElection
    {
        public class VoteResult
        {
            public int TopVotedPerson;
            public int Time;

            public VoteResult(int time, int person)
            {
                TopVotedPerson = person;
                Time = time;
            }
            public VoteResult(int time)
            {
                Time = time;
            }
            
        }
        
        public class TopVotedCandidate
        {
            private Dictionary<int, int> votingRecords;
            private LinkedList<VoteResult> topVotedCandidateRecords;

            public TopVotedCandidate(int[] persons, int[] times)
            {
                votingRecords = new Dictionary<int, int>();
                topVotedCandidateRecords = new LinkedList<VoteResult>();
                InformationIngession(persons, times);
            }

            public int Q(int t)
            {
                LinkedListNode<VoteResult> currentNode = topVotedCandidateRecords.First;
                int topVotedPerson = currentNode.Value.TopVotedPerson;
                while (currentNode != null && currentNode.Value.Time <= t)
                {
                    topVotedPerson = currentNode.Value.TopVotedPerson;
                    currentNode = currentNode.Next;
                }

                return topVotedPerson;
            }

            private void InformationIngession(int[] persons, int[] times)
            {
                int length = persons.Length;
                for (int i = 0; i < length; i++)
                {
                    int curPersonVotes;
                    if (votingRecords.TryGetValue(persons[i], out curPersonVotes))
                    {
                        votingRecords[persons[i]] = curPersonVotes + 1;
                    }
                    else
                    {
                        votingRecords.Add(persons[i], 1);
                    }

                    VoteResult voteResultToAdd = new VoteResult(times[i]);
                    LinkedListNode<VoteResult> nodeToAdd = new LinkedListNode<VoteResult>(voteResultToAdd);
                    

                    if (topVotedCandidateRecords.Last != null)
                    {
                        int curTopVotedPerson = topVotedCandidateRecords.Last.Value.TopVotedPerson;
                        int curtopVotedPersonVotes = votingRecords[curTopVotedPerson];
                        if (votingRecords[persons[i]] >= curtopVotedPersonVotes)
                        {
                            voteResultToAdd.TopVotedPerson = persons[i];
                        }
                        else
                        {
                            voteResultToAdd.TopVotedPerson = curTopVotedPerson;
                        }
                    }
                    else
                    {
                        voteResultToAdd.TopVotedPerson = persons[i];
                    }
                    
                    topVotedCandidateRecords.AddLast(nodeToAdd);
                }
            }
        }
    }
}