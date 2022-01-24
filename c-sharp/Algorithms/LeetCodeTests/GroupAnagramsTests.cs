using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class GroupAnagramsTests
    {
        [Fact]
        public void TestCase1()
        {
            string[] strs = new[]
            {
                "eat", "tea", "tan", "ate", "nat", "bat"
            };
            var sol = new GroupAnagramsSolution();
            sol.GroupAnagrams(strs);
        }
    }
}