public class Solution {
    public int Compress(char[] chars) {
        int k = 0;
        int i = 0;
        while (i < chars.Length) {
            char currentChar = chars[i];
            int count = 0;

            while (i < chars.Length && chars[i] == currentChar) {
                i++;
                count++;
            }

            chars[k++] = currentChar;

            if (count > 1) {
                foreach (char digit in count.ToString()) {
                    chars[k++] = digit;
                }
            }
        }

        return k;
    }
}
