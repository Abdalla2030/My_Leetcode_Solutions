// Binary Search
// O(Len(piles)*Log(Max(piles)))
class Solution {
public:
    int minEatingSpeed(vector<int>& piles, int h) {
        long long low = 1;
        auto max_it = max_element(piles.begin(), piles.end());
        long long high = *max_it;
        while(low<=high){
            long long k = low + (high - low) / 2; 
            long long hours = 0 ;
            for(int pile : piles){
                hours += (static_cast<long long>(pile) + k - 1) / k;
            }
            if(hours>h){
                low = k + 1 ;
            }else{
                high = k-1;
            }

        }

        return static_cast<int>(low);
    }
};