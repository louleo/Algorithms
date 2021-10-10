using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms.RateLimiter
{
    public class TokenBucket
    {
        public DateTime LastAccessTime;
        public int AvailableTokenNumber;
    }
    
    public class TokenBucketRateLimiter: IRateLimiter
    {
        private TimeSpan _timeInterval;
        
        private Dictionary<int, TokenBucket> _cache;
        
        private int _limitOfRequests;
        
        public TokenBucketRateLimiter(int timeInterval, int limitOfRequests)
        {
            _timeInterval = TimeSpan.FromSeconds(timeInterval);
            _limitOfRequests = limitOfRequests;
            _cache = new Dictionary<int, TokenBucket>();
        }
        
         
        public bool IsAllow(int ClientId)
        {
            object lockOjbect = new Object();
            lock (lockOjbect)
            {
                TokenBucket currentClientTokenBucket;
                DateTime currentTime = DateTime.Now;
                if (_cache.TryGetValue(ClientId, out currentClientTokenBucket))
                {
                    if (currentTime - currentClientTokenBucket.LastAccessTime > _timeInterval)
                    {
                        currentClientTokenBucket.AvailableTokenNumber = _limitOfRequests - 1;
                        return true;
                    }
                    else
                    {
                        if (currentClientTokenBucket.AvailableTokenNumber > 0)
                        {
                            currentClientTokenBucket.AvailableTokenNumber =
                                currentClientTokenBucket.AvailableTokenNumber - 1;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    currentClientTokenBucket = new TokenBucket();
                    currentClientTokenBucket.LastAccessTime = currentTime;
                    currentClientTokenBucket.AvailableTokenNumber = _limitOfRequests - 1;
                    _cache.Add(ClientId, currentClientTokenBucket);
                    return true;
                }
            }
        }


    }


}