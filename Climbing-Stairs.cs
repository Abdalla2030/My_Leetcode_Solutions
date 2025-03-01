public class Solution {
    public int dpSolve(int n,List<int> dp){
        if(n<=2){
            return n ;
        }
        if(dp[n] == 0){
           dp[n] = dpSolve(n-1,dp) + dpSolve(n-2,dp);
        }
        return dp[n];

    }
    public int ClimbStairs(int n) {
        List<int> dp = new List<int>(new int[n+1]);
        return dpSolve(n,dp);
    }
}