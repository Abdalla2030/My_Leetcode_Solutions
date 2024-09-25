public class Solution {
    public int SubarraysDivByK(int[] nums, int k)
    {
            int size = nums.Length;

            for (int i = 1; i < size; i++)
            {
                nums[i] += nums[i - 1];
            }
            
            for(int i = 0; i < size; i++){
                nums[i] = nums[i] % k;
                if (nums[i] < 0)
                {
                    nums[i] += k; 
                }
            }

            int[] freq = new int[k];
            Array.Fill(freq, 0);
            int sol = 0;
            freq[0] = 1; 
            for (int i = 0; i < size; i++)
            {
                sol += freq[nums[i]];
                freq[nums[i]]++; 
            }

            return sol; 
  
    }
}
