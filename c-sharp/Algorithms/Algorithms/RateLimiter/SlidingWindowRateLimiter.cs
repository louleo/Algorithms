using System;
using System.Collections.Generic;

namespace Algorithms.RateLimiter
{
    public class SlidingWindowRateLimiter: IRateLimiter
    {

        private Dictionary<int, Queue<DateTime>> _cache;
        private TimeSpan _interval;
        private int _rateLimitation;

        public SlidingWindowRateLimiter(TimeSpan interval, int rateLimitation)
        {
            _cache = new Dictionary<int, Queue<DateTime>>();
            _interval = interval;
            _rateLimitation = rateLimitation;
        }
        
        public bool IsAllow(int ClientId)
        {
            return InternalIsAllow(ClientId);
        }

        public bool InternalIsAllow(int ClientId)
        {
            Queue<DateTime> clientQueue;
            DateTime currentDateTime = DateTime.Now;
            if (_cache.TryGetValue(ClientId, out clientQueue))
            {
                while (clientQueue.Peek() - currentDateTime > _interval)
                {
                    clientQueue.Dequeue();
                }

                if (clientQueue.Count >= _rateLimitation)
                {
                    return false;
                }
                else
                {
                    clientQueue.Enqueue(currentDateTime);
                    return true;
                }
            }
            else
            {
                clientQueue = new Queue<DateTime>();
                clientQueue.Enqueue(currentDateTime);
                _cache.Add(ClientId, clientQueue);
                return true;
            }
        }
        
    }
}