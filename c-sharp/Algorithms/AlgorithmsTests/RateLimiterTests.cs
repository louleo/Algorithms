using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Algorithms.RateLimiter;
using FluentAssertions;
using Xunit;

namespace AlgorithmsTests
{

    public class RateLimiterTests
    {
        [Fact]
        public void RateLimiter_should_return_true_when_requests_number_not_exceeds_limitation()
        {
            //Arrange
            IRateLimiter rateLimiter = new FixedWindowRateLimiter(1, 100);
            int clientID = 1;

            for (int i = 0; i < 50; i++)
            {
                rateLimiter.IsAllow(clientID);
            }

            //Act
            var result = rateLimiter.IsAllow(clientID);

            //Assert
            result.Should().BeTrue();
        }
        
        [Fact]
        public void TokenRateLimiter_should_return_true_when_requests_number_not_exceeds_limitation()
        {
            //Arrange
            int clientID = 1;

            int times = 0;
            DateTime startTime = DateTime.Now;
            DateTime currentTime = DateTime.Now;
            IRateLimiter rateLimiter = new TokenBucketRateLimiter(10, 10);
            List<bool> resultSet = new List<bool>();

            while (currentTime - startTime < TimeSpan.FromSeconds(10))
            {
  
                resultSet.Add(rateLimiter.IsAllow(clientID));

                currentTime = DateTime.Now;
                Thread.Sleep(500);
            }

            resultSet.Should().NotBeEmpty();
        }

        
    }
}