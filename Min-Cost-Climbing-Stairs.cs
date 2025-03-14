/*
    public class Solution {
    public int solveRecursive(int[] cost,int i){
        if(i>= cost.Length){
            return 0;
        }else{
            return cost[i]+Math.Min(solveRecursive(cost,i+1),solveRecursive(cost,i+2));
        }
    }
    public int MinCostClimbingStairs(int[] cost) {
        return Math.Min(solveRecursive(cost,0),solveRecursive(cost,1));
    }
}
*/
public class Solution {
    public int dpSolve(int n,int [] cost,int[] dp){
        if(n>= cost.Length){
            return 0 ;
        }
        if(dp[n] == -1){
            dp[n] = cost[n]+Math.Min(dpSolve(n+1,cost,dp),dpSolve(n+2,cost,dp));
        }
        return dp[n]; 
    }
    public int MinCostClimbingStairs(int[] cost) {
        int[] dp = new int[cost.Length];
        Array.Fill(dp,-1);
        return Math.Min(dpSolve(0,cost,dp),dpSolve(1,cost,dp));
    }
}