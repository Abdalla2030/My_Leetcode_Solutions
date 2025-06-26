// with O(1) Space Complexity
class Solution {
    public int[] productExceptSelf(int[] nums) {
        int pre = 1 ;
        int pos = 1 ; 

        int[] res = new int[nums.length];

        for(int i = 0 ;i<nums.length;i++){
            res[i] = pre ;
            pre *= nums[i] ;
        }
        for(int i = nums.length-1;i>=0;i--){
            res[i] *= pos ;
            pos *= nums[i];
        }
        return res; 
    }
}