class Solution {
public:
    int largestAltitude(vector<int>& gain) {
       int maxi = 0, sum = 0 ; 
       for(int i = 0;i<gain.size();i++){
            sum += gain[i];
            maxi = max(maxi,sum);
       } 
       return maxi ; 
    }
};