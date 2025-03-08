public class Solution {
    public int LargestAltitude(int[] gain) {
        int maxi = 0, sum = 0 ; 
       for(int i = 0;i<gain.Length;i++){
            sum += gain[i];
            maxi = Math.Max(maxi,sum);
       } 
       return maxi ; 
    }
}