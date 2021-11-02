using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class RankTeamsByVotesTests
    {
        [Fact]
        public void TestCase1()
        {
            string[] testArr = {"WXYZ", "XYZW"};

            RankTeamsByVotesSolution solution = new RankTeamsByVotesSolution();

            string result = solution.RankTeams(testArr);

            result.Should().Be("XWYZ");
        }
    }
}