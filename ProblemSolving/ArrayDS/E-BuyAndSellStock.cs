namespace ProblemSolving.ArrayDS;

internal static class E_BuyAndSellStock
{
    /* 
     * L = Buy
     * R = Sell
     * if R<L, then move L ahead by 1 position and R by 1 position( if sell is less buy, we are not making profit, so we have to increase buy(L) to the right
     * if R>L, then calculate profit and since left is less than right, then Move R to next position and there should not be any change to left position
     * repeat the process and compare with maximum profit
     * 
     * */

    /// <summary>
    /// Time Complexity - O(n) SpaceComplexity - O(1)
    /// </summary>  
    public static int maxProfit()
    {
        int[] prices = [7, 1, 5, 3, 6, 4];
        int l = 0; // left = buy
        //int r = 1; //right = sell

        int maxProfit = 0;

        for (int r = 1; r < prices.Length; r++)
        {
            if (prices[l] < prices[r])
            {
                int profit = prices[r] - prices[l];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
                l = r;
        }
        return maxProfit;
    }
}

