class Solution {
    public int[] countBits(int n) {
        int[] res = new int[n+1];
        for(int i = 0;i<=n;i++){
            int cnt = 0 ; 
            int x = i ; 
            while(x>0){
                cnt +=  x & 1 ; 
                x = x >> 1 ; 
            }
            res[i] = cnt ; 
        }

        return res ; 
    }
}