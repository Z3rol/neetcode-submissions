public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            if (prices[i] - minPrice > maxProfit)
                maxProfit = prices[i] - minPrice;
        }

        if (maxProfit < 0) return 0;

        return maxProfit;
    }
}
