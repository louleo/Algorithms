using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Algorithms.RateLimiter
{
    public class FixedWindowRateLimiter: IRateLimiter
    {

        //based on milliseconds
        private TimeSpan _timeInterval;
        
        private int _maxNumberOfRequests;

        private ConcurrentDictionary<int, int> _cache;

        private DateTime _startedTimeStamp;

        public FixedWindowRateLimiter(int timeInterval, int maxNumberOfRequests)
        {
            _timeInterval = TimeSpan.FromSeconds(timeInterval);
            _startedTimeStamp = new DateTime();
            _maxNumberOfRequests = maxNumberOfRequests;
            _cache = new ConcurrentDictionary<int, int>();
        }
        
        public bool IsAllow(int ClientID)
        {
            DateTime currentTimeStamp = new DateTime();
            if (currentTimeStamp - _startedTimeStamp > _timeInterval)
            {
                ResetCache();
                _startedTimeStamp = currentTimeStamp;
            }

            int numberOfRequests;

            if (_cache.TryGetValue(ClientID, out numberOfRequests))
            {
                numberOfRequests++;
                if (numberOfRequests > _maxNumberOfRequests)
                {
                    return false;
                }
                else
                {
                    _cache.TryUpdate(ClientID, numberOfRequests);
                    return true;
                }
            }
            else
            {
                _cache.TryAdd(ClientID, 1);
                return true;
            }
        }

        private void ResetCache()
        {
            _cache.Clear();
        }
    }
}