class Solution {
    public int minFlips(int a, int b, int c) {
        int flips = 0 ;

        while (a > 0 || b > 0 || c > 0){
            int aBit = a & 1 ;
            int bBit = b & 1 ;
            int cBit = c & 1 ;

            if(cBit == 1 ){
                // If c needs a 1, at least one of a or b must be 1.
                // If both are 0, we need one flip (turn one of them to 1).
                if (aBit == 0 && bBit == 0) {
                    flips += 1;
                }
            }else{
                // If c needs a 0, both a and b must be 0.
                // Each 1 here needs to be flipped to 0.
                flips += aBit + bBit;
            }
            // Move to the next bit (right shift)
            a >>= 1;
            b >>= 1;
            c >>= 1;
        }
        return flips ; 
    }
}