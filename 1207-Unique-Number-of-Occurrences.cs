public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        int[] freq = new int[arr.Length+1]; 
        Array.Fill(freq,0);


        for(int i = 0;i<arr.Length;i++){
            if(dic.ContainsKey(arr[i])){
                dic[arr[i]]++; 
            }else{
                dic[arr[i]] = 1;
            }
             
            
        }

        foreach (KeyValuePair<int, int> entry in dic) {
           if(freq[entry.Value] != 0){
            return false ;
           }
           freq[entry.Value] = entry.Key;
        }

        return true ; 
    }
}