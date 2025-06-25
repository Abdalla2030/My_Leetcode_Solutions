class Solution {
public:
    bool increasingTriplet(vector<int>& nums) { 
        int first = INT_MAX, second = INT_MAX;

       for (int num : nums) {
            if (num <= first) {
                first = num;  
            } else if (num <= second) {
                second = num;  
            } else { // found third num > (first and second)
                return true;
            }
        }
        return false ;
    }
};