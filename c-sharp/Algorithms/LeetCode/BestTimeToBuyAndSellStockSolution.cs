namespace LeetCode
{
    public class BestTimeToBuyAndSellStockSolution
    {
        public int MaxProfit(int[] prices)
        {
            return MaxProfit1(prices);
        }

        public int MaxProfit1(int[] prices)
        {
            int left = 0;
            int right = left + 1;
            int profit = 0;
            while (right < prices.Length)
            {
                if (prices[left] > prices[right])
                {
                    left = right;
                    right++;
                }
                else
                {
                    int newProfit = prices[right] - prices[left];
                    if (newProfit > profit)
                    {
                        profit = newProfit;
                    }

                    right++;
                }
            }

            return profit;
        }

        public int MaxProfit2(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }

            return profit;
        }
    }
}