using System;
using System.Collections.Generic;
using System.Threading;
using Algorithms.RateLimiter;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientID = 1;

            int times = 0;
            DateTime startTime = DateTime.Now;
            DateTime currentTime = DateTime.Now;
            DateTime currentTime2= DateTime.Now;

            IRateLimiter rateLimiter = new LeakyBucketRateLimiter(10, 10);
            Thread newThread = new Thread(() =>
            {
                while (currentTime2 - startTime < TimeSpan.FromSeconds(20))
                {
                    Console.WriteLine($"isAllow--1---${rateLimiter.IsAllow(clientID)}");

                    currentTime2 = DateTime.Now;
                    Thread.Sleep(500);
                }
            });
            newThread.Start();
            while (currentTime - startTime < TimeSpan.FromSeconds(20))
            {
                Console.WriteLine($"isAllow---2--${rateLimiter.IsAllow(clientID)}");

                currentTime = DateTime.Now;
                Thread.Sleep(500);
            }
            Console.WriteLine("Finished.");
        }
    }
}