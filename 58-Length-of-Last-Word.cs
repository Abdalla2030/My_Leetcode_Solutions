public class Solution {
    public int LengthOfLastWord(string s) {

        int i = s.Length-1 ;
        int k = 0;
        while(s[i] == ' '){
            k++;
            i--;
        }

        int cnt = 0 ;

        for(int j = i ; j>=0;j--){
            if(s[j]==' '){
                return cnt;
            }
            cnt++;
        }
        return s.Length-k ; 
    }
}