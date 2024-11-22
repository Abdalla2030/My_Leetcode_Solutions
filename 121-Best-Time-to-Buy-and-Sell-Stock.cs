public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0 ;

        foreach(int price in prices){
            minPrice = Math.Min(minPrice , price);
            maxProfit = Math.Max(maxProfit , price - minPrice);
        }

        return maxProfit ; 
    }
}