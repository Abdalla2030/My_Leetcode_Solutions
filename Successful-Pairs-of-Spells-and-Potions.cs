public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success){
        int n = spells.Length;
        int m = potions.Length;
        int[] res = new int[n];
        Array.Fill(res,0);
        Array.Sort(potions);

        for(int i = 0;i<n;i++){
            int l= 0,r = m ;
            while(l<r){
               int mid = l + (r-l)/2 ; 
               if((long)spells[i] * potions[mid]<success){
                    l = mid+1;
               }

               else if((long)spells[i] * potions[mid]>=success){
                    r = mid;
               }

               }

               res[i] = m-l;

            }
        return res;
    }
}