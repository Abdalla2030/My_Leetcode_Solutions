class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int total = 1 ;
        int zeroCount = 0;
        for(int num:nums){
            if (num == 0) zeroCount++;
            else total *= num; 
        }
        vector<int> res(nums.size());

        if (zeroCount == 0) {
            for (int i = 0; i < nums.size(); i++)
                res[i] = total / nums[i];
            } 
        else if (zeroCount == 1) {
            for (int i = 0; i < nums.size(); i++)
                if (nums[i] == 0) res[i] = total;
       }
        return res;
    }
};