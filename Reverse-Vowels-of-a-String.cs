public class Solution {
    public string ReverseVowels(string s) {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' }; 
        int i = 0, j = s.Length - 1;
        char[] charArray = s.ToCharArray(); 

        while (i < j) {
            while (i < s.Length && !vowels.Contains(char.ToLower(charArray[i]))) {
                i++;
            }
            while (j >= 0 && !vowels.Contains(char.ToLower(charArray[j]))) {
                j--;
            }

            if (i < j) {
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                i++;
                j--;
            }
        }

        return new string(charArray);
    }
}
