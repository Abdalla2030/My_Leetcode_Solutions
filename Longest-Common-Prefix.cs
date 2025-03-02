public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string ans = \\ ; 
        for(int i = 0;i<strs[0].Length;i++){
            char c = strs[0][i];
            for(int j=1;j<strs.Length;j++){
                if(i >= strs[j].Length || strs[j][i] != c){
                    return ans ;
                }
            }
            ans += strs[0][i];
        }
        return ans;
    }
}