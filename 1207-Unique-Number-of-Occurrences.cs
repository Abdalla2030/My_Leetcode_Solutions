public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> dic = new Dictionary <int,int>();
        foreach (int item in arr){
            if(dic.ContainsKey(item)){
                dic[item]++;
            }
            else{
                dic[item] = 1 ; 
            }
           
        }

        HashSet<int> set = new HashSet<int>();
        foreach (int value in dic.Values) {
            if(!set.Add(value)){
                return false;
            }
        }

        return true;

    }
}