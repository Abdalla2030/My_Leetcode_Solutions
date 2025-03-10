public class Solution {
    public int LongestSubarray(int[] nums) {
        int left = 0 , right = 0 ;
        int maxi = 0 ; 
        int zeroCount = 0 ;
        while(right<nums.Length){
            if(nums[right]==0){
                zeroCount++;
            }

            while(zeroCount>1){
                if(nums[left]==0){
                    zeroCount--;
                }
                left++; 
            }
            maxi = Math.Max(maxi,right-left);
            right++; 
        }

        return maxi ; 
    }
}