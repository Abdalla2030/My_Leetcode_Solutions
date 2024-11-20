public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        int [] res = new int [2];
        int j = 0 ; 

        foreach (int num in nums) {
            if (frequencyMap.ContainsKey(num)) {
                frequencyMap[num]++;

                if (frequencyMap[num] == 2) {
                    res[j++] = num ; 
                }
            } else {
                frequencyMap[num] = 1;
            }     
        }
        return res; 
    }
}