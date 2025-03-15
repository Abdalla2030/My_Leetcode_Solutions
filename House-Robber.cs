/*
public class Solution {
    public int solveRecursive(int[] nums,int i){
        if(i>= nums.Length){
            return 0;
        }else{
            return Math.Max(nums[i]+solveRecursive(nums,i+2),solveRecursive(nums,i+1));
        }
    }
    public int Rob(int[] nums) {
        return Math.Max(solveRecursive(nums,0),solveRecursive(nums,1));
    }
}
*/
public class Solution {
    public int dpSolve(int n,int [] nums,int[] dp){
        if(n>= nums.Length){
            return 0 ;
        }
        if(dp[n] == -1){
            dp[n] = Math.Max(nums[n]+dpSolve(n+2,nums,dp),dpSolve(n+1,nums,dp));
        }
        return dp[n]; 
    }
    public int Rob(int[] nums) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp,-1);
        return Math.Max(dpSolve(0,nums,dp),dpSolve(1,nums,dp));
    }
}