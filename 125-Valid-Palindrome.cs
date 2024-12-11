public class Solution {
    public bool IsPalindrome(string s) {
      StringBuilder sb = new StringBuilder();
      foreach(char c in s){
        // I create c2 because i can not change c in foreach
        char c2 = char.ToLower(c);
        if((c2>=97 && c2<=122) || (c2>=48 && c2<=57) ){
         sb.Append(c2);
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