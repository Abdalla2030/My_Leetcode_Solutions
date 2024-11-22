public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0 , right = 1 ;
        int res = 0 ;

        while(right<prices.Length){
            if(prices[left]<prices[right]){
                res = Math.Max(res,prices[right]-prices[left]);
            }else{
                left = right;
            }
            right++;
        }
        return res; 
    }
}