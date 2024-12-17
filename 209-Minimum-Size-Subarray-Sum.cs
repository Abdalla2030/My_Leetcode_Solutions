public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
       int ans = int.MaxValue;
       int l = 0 ;
       int sum = 0 ; 
       for(int r = 0;r<nums.Length;r++){
         sum+= nums[r];
         while(sum>=target){
            ans = Math.Min(ans,r-l+1);
            sum -= nums[l];
            l++; 
         }
       }
        return ans==int.MaxValue?0:ans; 

    }
}