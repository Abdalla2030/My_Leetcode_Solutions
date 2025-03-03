public class Solution {
    public int PivotIndex(int[] nums) {
       int sum1 = 0 , sum2 = 0 ;
       for(int i = 0 ;i<nums.Length;i++){
         sum1+= nums[i];
       }
       for(int i = 0 ;i<nums.Length;i++){
            if(sum2 == sum1 - sum2 - nums[i]){
                return i;
            }
            sum2 += nums[i];
       }
       return -1 ; 
    }
}