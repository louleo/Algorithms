using System;
using System.Collections.Generic;

namespace Algorithms.RateLimiter
{
    public class LeakyBucketRateLimiter: IRateLimiter
    {
        private Dictionary<int, Queue<DateTime>> _cache;
        private TimeSpan _timeInterval;
        private int _rateLimitation;

        public LeakyBucketRateLimiter(int timeIntervalInSeconds, int rateLimitation)
        {
            _rateLimitation = rateLimitation;
            _timeInterval = TimeSpan.FromSeconds(timeIntervalInSeconds);
            _cache = new Dictionary<int, Queue<DateTime>>();
        }
        
        public bool IsAllow(int ClientId)
        {
            object lockObject = new object();
            lock (lockObject)
            {
                Queue<DateTime> currentClientQueue;
                DateTime currentTime = DateTime.Now;
                if (_cache.TryGetValue(ClientId, out currentClientQueue))
                {
                    DateTime firstDateTimeinQueue = currentClientQueue.Peek();
                    while (currentTime - firstDateTimeinQueue > _timeInterval)
                    {
                        firstDateTimeinQueue = currentClientQueue.Dequeue();
                    }

                    if (currentClientQueue.Count >= 10)
                    {
                        return false;
                    }
                    else
                    {
                        currentClientQueue.Enqueue(currentTime);
                        return true;
                    }
                }
                else
                {
                    currentClientQueue = new Queue<DateTime>();
                    currentClientQueue.Enqueue(currentTime);
                    _cache.Add(ClientId, currentClientQueue);
                    return true;
                }
            }

        }
        
    }
}