public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0 ;
        HashSet<char> seen = new HashSet<char>();
        int l = 0 ;
        for(int r = 0 ;r<s.Length;r++){
            while(seen.Contains(s[r])){
                seen.Remove(s[l]);
                l++; 
            }
            seen.Add(s[r]);
            ans = Math.Max(ans,r-l+1);
        }
        return ans; 
    }
}