using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class BestTimeToBuyAndSellStockTests
    {
        [Theory]
        [InlineData(new []{7,1,5,3,6,4}, 5)]
        [InlineData(new []{7,6,4,3,1}, 0)]
        public void TestCase1(int[] prices, int result)
        {
            var sol = new BestTimeToBuyAndSellStockSolution();
            sol.MaxProfit(prices).Should().Be(result);
        }
    }
}