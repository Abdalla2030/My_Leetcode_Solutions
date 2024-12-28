public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int l = 0 , r = 0 ;
        int maxi = 0 ;
        for(r = 0;r<nums.Length;r++){
            k -= 1-nums[r];
            if(k<0){
                k += 1-nums[l];
                l++; 
            }else{
                maxi = Math.Max(maxi,r-l+1);
            }
        }

        return maxi ;
    }
}