public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, char> mapS = new Dictionary<char, char>();
        Dictionary<char, char> mapT = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++) {
            if (mapS.ContainsKey(s[i])) {
                if (mapS[s[i]] != t[i]) {
                    return false;
                }
            } else {
                mapS[s[i]] = t[i];
            }

            if (mapT.ContainsKey(t[i])) {
                if (mapT[t[i]] != s[i]) {
                    return false;
                }
            } else {
                mapT[t[i]] = s[i];
            }
        }
        return true;
    }
}
