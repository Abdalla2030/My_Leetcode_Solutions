public class Solution {
    public bool IsPalindrome(string s) {
      StringBuilder sb = new StringBuilder();
      foreach(char c in s){
        // or char c2 = char.ToLower(c) 
        if(char.IsLetterOrDigit(c)){
         sb.Append(char.ToLower(c));
      }  
     }

    int i = 0 , j = sb.Length-1 ; 
    while(i<j){
        if(sb[i] != sb[j]){
            return false;
        }
        i++;
        j--;
    }
    return true; 
    }
}