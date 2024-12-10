public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int j = 0 ;
        nums[j++] = nums[0];
        for(int i = 1;i<nums.Length;i++){
            if(nums[i] != nums[j-1] ){
                nums[j] = nums[i];
                j++; 
            }
        }

        return j; 
    }
}