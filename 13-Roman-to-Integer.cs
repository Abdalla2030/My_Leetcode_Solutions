public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> roman = new Dictionary<char, int>();
        roman.Add('I',1);
        roman.Add('V',5);
        roman.Add('X',10);
        roman.Add('L',50);
        roman.Add('C',100);
        roman.Add('D',500);
        roman.Add('M',1000);

        int sum = 0 ;
        for(int i = 0;i<s.Length;i++){
            if(i != s.Length-1 && roman[s[i]] < roman[s[i+1]]){
                sum += roman[s[i+1]] - roman[s[i]];
                i++;
            }else{
                sum += roman[s[i]];
            }
        }

        return sum ; 

    }
}