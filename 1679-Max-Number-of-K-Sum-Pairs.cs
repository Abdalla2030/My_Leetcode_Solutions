public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var freq = new Dictionary<int, int>();  
        int ans = 0;

        foreach (var num in nums) {
            int complement = k - num;
            if (freq.ContainsKey(complement) && freq[complement] > 0) {
                ans++; 
                freq[complement]--;  
            } else {
                if (freq.ContainsKey(num)) {
                    freq[num]++;
                } else {
                    freq[num] = 1; 
                }
            }
        }

        return ans; 
    }
}
