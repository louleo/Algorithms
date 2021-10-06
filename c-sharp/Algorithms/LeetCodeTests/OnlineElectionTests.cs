using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class OnlineElectionTests
    {
        [Fact]
        public void TestCase1()
        {
            int[] persons = new[]
            {
                0, 1, 1, 0, 0, 1, 0
            };

            int[] times = new[]
            {
                0,5,10,15,20,25,30
            };

            OnlineElection.TopVotedCandidate tvc = new OnlineElection.TopVotedCandidate(persons, times);

            tvc.Q(3).Should().Be(0);
            tvc.Q(12).Should().Be(1);
            tvc.Q(25).Should().Be(1);
            tvc.Q(15).Should().Be(0);
        }
    }
}