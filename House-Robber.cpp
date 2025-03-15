/*
     int rob(vector<int>& nums) {
        int n = nums.size();
        vector<int> dp(n+1,0);
        dp[n] = 0 ;
        dp[n-1] = nums[n-1];
        for(int i = n-2 ;i>=0;i--){
            dp[i] = max(nums[i]+dp[i+2],dp[i+1]);
        }
        return dp[0];
    }
*/
class Solution {
public:
    int rob(vector<int>& nums) {
        int n = nums.size();
        int prev2 = 0 ;
        int prev1 = nums[n-1];
        for(int i = n-2 ;i>=0;i--){
           int curr = max(nums[i]+prev2,prev1);
           prev2 = prev1;
           prev1 = curr;

        }
        return prev1;
    }
};