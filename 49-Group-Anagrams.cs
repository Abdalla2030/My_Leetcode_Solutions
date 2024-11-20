public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> frequencyMap = new Dictionary<string, IList<string>>();

        foreach(string s in strs){
            string sortedString = new string(s.OrderBy(c => c).ToArray());
            if(frequencyMap.ContainsKey(sortedString)){
                frequencyMap[sortedString].Add(s);
            }else{
                frequencyMap[sortedString] = new List<string> { s };
            }

        }

        return new List<IList<string>>(frequencyMap.Values);
    }
}