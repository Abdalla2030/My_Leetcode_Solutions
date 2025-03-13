/*

    if(n == 0){
        return n;
    }else if(n==1 || n==2){
        return 1;
    }else{
        return Tribonacci(n-1)+Tribonacci(n-2)+Tribonacci(n-3);
    }

*/
public class Solution {
    public int dpSolve(int n,List<int> dp){
        if(n == 0){
            return n;
        } 
        else if(n<=2){
            return 1;
        }
        if(dp[n] == 0){
           dp[n] = dpSolve(n-1,dp) + dpSolve(n-2,dp)+ dpSolve(n-3,dp);
        }
        return dp[n];
    }
    public int Tribonacci(int n) {
        List<int> dp = new List<int>(new int[n+1]);
        return dpSolve(n,dp);
    }
}