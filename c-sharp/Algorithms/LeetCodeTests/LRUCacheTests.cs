using System;
using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{

    public class LRUCacheTests
    {
        public LRUCache Cache;
        
        [Fact]
        public void LCRCacheTestCase1()
        {

            LRUCache cache = new LRUCache(2);
            List<Tuple<string, int, int>> testCases = new List<Tuple<string, int, int>>
            {
                new Tuple<string, int, int>("put", 2, 1),
                new Tuple<string, int, int>("put", 2, 2),
                new Tuple<string, int, int>("get", 2, 2),
                new Tuple<string, int, int>("put", 1, 1),
                new Tuple<string, int, int>("put", 4, 1),
                new Tuple<string, int, int>("get", 2, -1)
            };

            for (int i = 0; i < testCases.Count; i++)
            {
                var tuple = testCases[i];
                switch (tuple.Item1)
                {
                    case "put":
                        cache.Put(tuple.Item2, tuple.Item3);
                        break;
                    case "get":
                        cache.Get(tuple.Item2).Should().Be(tuple.Item3);
                        break;
                }
            }


        }


        private void CacheInit(int capability)
        {
            Cache = new LRUCache(capability);
        }
        
    }
}