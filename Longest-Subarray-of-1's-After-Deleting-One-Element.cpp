class Solution {
public:
    int longestSubarray(vector<int>& nums) {
        int left = 0 ;
        int max_len = 0 ;
        int last_zero = -1 ;

        for(int right = 0 ;right<nums.size();right++){
            if(nums[right]==0){
                left = last_zero + 1 ;
                last_zero = right;
            }
            max_len = max(max_len,right-left);
        }

        return max_len;
    }
};