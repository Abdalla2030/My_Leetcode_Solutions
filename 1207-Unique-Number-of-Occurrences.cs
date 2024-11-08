public class Solution {

    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (int num in arr) {
            if (dic.ContainsKey(num)) {
                dic[num]++;
            } else {
                dic[num] = 1;
            }
        }

        HashSet<int> uniqueFrequencies = new HashSet<int>();

        foreach (var entry in dic) {
            if (!uniqueFrequencies.Add(entry.Value)) {
                return false; 
            }
        }

        return true; 
    }
       
}