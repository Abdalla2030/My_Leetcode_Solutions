public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> boolList = new List<bool>();
        int maxi = 0 ;
        for(int i = 0;i<candies.Length;i++){
            maxi = Math.Max(maxi,candies[i]);
        }

        for(int i = 0;i<candies.Length;i++){
            if(candies[i]+extraCandies >= maxi){
                boolList.Add(true);
                //maxi = candies[i]+extraCandies;
            }else{
                boolList.Add(false);
            }
        }
        return boolList;
    }
}