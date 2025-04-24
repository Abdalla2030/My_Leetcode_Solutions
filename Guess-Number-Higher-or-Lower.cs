/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return \t     -1 if num is higher than the picked number
 *\t\t\t      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int l = 1 , r = n ;
        while(true){
            int m = l + (r - l) / 2;
            int res = guess(m);
            if(res<0){
               r = m-1;
            }else if(res>0){
                l = m+1 ;
            }else{
                return m ; 
            }
        }
    }
}