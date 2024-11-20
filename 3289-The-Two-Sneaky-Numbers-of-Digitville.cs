public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
         int[] freq = new int[nums.Length+5]; 
         Array.Fill(freq,0);

         int [] res = new int [2];
         int j = 0 ; 

         for(int i = 0 ;i<nums.Length;i++){
            freq[nums[i]]++;

            if(  freq[nums[i]] == 2){
                res[j++] = nums[i];
            }
         }

         return res;


    }
}