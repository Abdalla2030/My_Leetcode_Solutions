public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        int[] freq = new int[26];
        Array.Fill(freq, 0);

        for(int i = 0 ;i<s.Length;i++){
            freq[s[i]-'a']++;
        }

         for (int i = 0; i < t.Length; i++) {
            freq[t[i] - 'a']--;
            if (freq[t[i] - 'a'] < 0) {
                return false;
            }
        }
        return true;
    }
}