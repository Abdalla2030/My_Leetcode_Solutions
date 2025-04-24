public class Solution {
    public int MinOperations(int[] nums, int k) {
        HashSet<int> st = new HashSet<int>(); 
        for(int i = 0;i<nums.Length;i++){
            if(nums[i]<k){
                return -1;
            }else if(nums[i]>k){
                st.Add(nums[i]);
            }
        }
        return st.Count;
    }
}