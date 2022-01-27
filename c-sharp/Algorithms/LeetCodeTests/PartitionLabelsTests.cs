using System.Collections.Generic;
using System.ComponentModel;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class PartitionLabelsTests
    {
        [Fact]
        public void TestCase()
        {
            string input = "ababcbacadefegdehijhklij";
            List<int> output = new List<int>()
            {
                9, 8, 7
            };
            var sol = new PartitionLabelsSolution();
            sol.PartitionLabels(input).Should().BeEquivalentTo(output);
        }        
        
        [Fact]
        public void TestCase2()
        {
            string input ="eaaaabaaec";
            List<int> output = new List<int>()
            {
                9, 1
            };
            var sol = new PartitionLabelsSolution();
            sol.PartitionLabels(input).Should().BeEquivalentTo(output);
        }
    }
}