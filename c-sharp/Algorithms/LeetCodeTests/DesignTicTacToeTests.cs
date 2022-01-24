using FluentAssertions;
using LeetCode.DesignTicTacToe;
using Xunit;

namespace LeetCodeTests
{
    public class DesignTicTacToeTests
    {
        [Fact]
        public void TestCase1()
        {
            var sol = new TicTacToe(2);
            sol.Move(0, 0, 2);
            sol.Move(0, 1, 1);
            sol.Move(1, 1, 2).Should().Be(2);
        }
    }
}