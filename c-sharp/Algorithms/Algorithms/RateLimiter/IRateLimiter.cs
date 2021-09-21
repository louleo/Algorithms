namespace Algorithms.RateLimiter
{
    public interface IRateLimiter
    {
        bool IsAllow(int ClientId);
    }
}