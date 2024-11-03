public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> unique = new HashSet<int>();

        for(int i = 0 ;i<nums.Length;i++){
            if(unique.Contains(nums[i])){
                return true; 
            }
            unique.Add(nums[i]);
        }

        return false;
    }
}