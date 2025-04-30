class Solution {
public:
    vector<int> successfulPairs(vector<int>& spells, vector<int>& potions, long long success) {
        vector<int> res(spells.size(),0);
        sort(potions.begin(),potions.end());
        for(int i = 0 ;i<spells.size();i++){
            int l = 0 , r = potions.size();
            while(l<r){
                int m = l + (r-l)/2 ;
                if((long long)spells[i]*potions[m]>=success){
                    r = m ;
                }else{
                    l = m+1 ; 
                }
            }

            res[i] = potions.size()-l ; 
        }

        return res;

    }
};