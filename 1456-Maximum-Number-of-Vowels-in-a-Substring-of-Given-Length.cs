public class Solution {
    public int MaxVowels(string s, int k) {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        int ans = 0,sum = 0 ;

        for(int i = 0 ;i<k;i++){
            if(vowels.Contains(s[i])){
                sum++; 
            }
        }
        
        ans = Math.Max(ans,sum);

        for(int i = k ;i<s.Length;i++){
            if(vowels.Contains(s[i-k])){
               sum--;  
            }
            if(vowels.Contains(s[i])){
               sum++; 
            }
            ans = Math.Max(ans,sum);
        }
        return ans ; 
    }
}