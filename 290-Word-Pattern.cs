public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        if (pattern.Length != words.Length) {
            return false;
        }
        Dictionary<char, string> mapP = new Dictionary<char, string>();
        Dictionary<string, char> mapS = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++) {
            if (mapP.ContainsKey(pattern[i])) {
                if (mapP[pattern[i]] != words[i]) {
                    return false;
                }
            } else {
                mapP[pattern[i]] = words[i];
            }

            if (mapS.ContainsKey(words[i])) {
                if (mapS[words[i]] != pattern[i]) {
                    return false;
                }
            } else {
                mapS[words[i]] = pattern[i];
            }
        }
        return true;
    }
}