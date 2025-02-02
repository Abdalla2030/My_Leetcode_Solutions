public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for(int i = 0;i<nums.Length;i++){
            if(dic.ContainsKey(nums[i])){
                dic[nums[i]]++;
            }else{
              dic[nums[i]] = 1 ;  
            }
        }
        
        foreach (KeyValuePair<int, int> kvp in dic){
            if(kvp.Value > nums.Length/2){
                return kvp.Key;
            }
        }

        return -1 ;


    }
}