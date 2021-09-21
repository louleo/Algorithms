using System;
using System.Collections.Generic;
using System.Linq;
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
        public void RateLimiter_should_return_false_when_requests_number_exceeds_limitation()
        {
            //Arrange
            IRateLimiter rateLimiter = new FixedWindowRateLimiter(1, 10);
            int clientID = 1;
            int clientID2 = 2;
            List<bool> results1 = new List<bool>();
            List<bool> results2 = new List<bool>();

            Task rateLimiter1 = Task.Run(() =>
            {
                for (int i = 0; i < 11; i++)
                {
                    results1.Append(rateLimiter.IsAllow(clientID));
                }
            });

            Task rateLimiter2 = Task.Run(() =>
            {
                for (int i = 0; i < 11; i++)
                {
                    results2.Append(rateLimiter.IsAllow(clientID));
                }
            });

            Task.WaitAll(rateLimiter1, rateLimiter2);

            //Act
            var result = rateLimiter.IsAllow(clientID);

            //Assert
            result.Should().BeFalse();
        }
    }
}