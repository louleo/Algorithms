using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class NumberOfIslandsTests
    {
        [Fact]
        public void TestCase1()
        {
            char[][] grid = new[]
            {
                new[]
                {
                    '1', '1', '1', '1', '0'
                },
                new[]
                {
                    '1', '1', '0', '1', '0'
                },
                new[]
                {
                    '1', '1', '0', '0', '0'
                },
                new[]
                {
                    '0', '0', '0', '0', '0'
                }
            };
            var result = 1;
            var sol = new NumberOfIslandsSolution();

            sol.NumIslands(grid).Should().Be(result);
        }
        
        
        [Fact]
        public void TestCase2()
        {
            char[][] grid = new[]
            {
                new[]
                {
                    '1', '1', '1', '1', '0'
                },
                new[]
                {
                    '0', '0', '0', '1', '0'
                },
                new[]
                {
                    '1', '1', '0', '0', '1'
                },
                new[]
                {
                    '0', '0', '0', '1', '1'
                }
            };
            var result = 3;
            var sol = new NumberOfIslandsSolution();

            sol.NumIslands(grid).Should().Be(result);
        }
    }
}