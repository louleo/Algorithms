using System;
using System.Collections.Generic;

namespace Algorithms.RateLimiter
{
    public class TokenBucketRateLimiter: IRateLimiter
    {
        private TimeSpan _timeInterval;
        
        private Dictionary<int, int> _cache;

        private DateTime _windowStart;

        private int _limitOfRequests;

        public TokenBucketRateLimiter(int timeInterval, int limitOfRequests)
        {
            _timeInterval = TimeSpan.FromSeconds(timeInterval/limitOfRequests);
            _limitOfRequests = limitOfRequests;
            _cache = new Dictionary<int, int>();
            _windowStart = new DateTime();
        }
        public bool IsAllow(int ClientId)
        {
            DateTime currentTimestamp = new DateTime();
            return true;
        }

        private void AddToken()
        {
            foreach (KeyValuePair<int, int> keyValuePair in _cache)
            {

            }
        }
    }
}