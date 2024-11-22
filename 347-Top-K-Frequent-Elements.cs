public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequency = new Dictionary<int,int>();

        for(int i=0 ; i<nums.Length;i++){
            if(frequency.ContainsKey(nums[i])){
                frequency[nums[i]]++;
            }else{
                frequency[nums[i]] = 1 ; 
            }
        }

        var sortedByValuesDesc = frequency.OrderByDescending(entry => entry.Value).ToList();


        int[] result = new int[k];
        for (int i = 0; i < k; i++) {
            result[i] = sortedByValuesDesc[i].Key;
        }

        return result;

    }
}