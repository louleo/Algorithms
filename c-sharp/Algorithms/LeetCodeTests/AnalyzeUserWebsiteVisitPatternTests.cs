using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class AnalyzeUserWebsiteVisitPatternTests
    {
        [Fact]
        public void TestCase1()
        {
            string[] users = new[]
            {
                "h","eiy","cq","h","cq","txldsscx","cq","txldsscx","h","cq","cq"
            };
            int[] timestamps = new[]
            {
                527896567, 334462937, 517687281, 134127993, 859112386, 159548699, 51100299, 444082139, 926837079,
                317455832, 411747930
            };

            string[] websites = new[]
            {
                "hibympufi","hibympufi","hibympufi","hibympufi","hibympufi","hibympufi","hibympufi","hibympufi","yljmntrclw","hibympufi","yljmntrclw"
            };

            var sol = new AnalyzeUserWebsiteVisitPatternSolution();
            sol.MostVisitedPattern(users, timestamps, websites);
        }
    }
}