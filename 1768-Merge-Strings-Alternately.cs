public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder merged = new StringBuilder();
        int len1 = word1.Length;
        int len2 = word2.Length;
        int i = 0, j = 0;
         while (i < len1 || j < len2)
        {
            if (i < len1)
                merged.Append(word1[i++]);

            if (j < len2)
                merged.Append(word2[j++]); 
        }

        return merged.ToString();
    }
}