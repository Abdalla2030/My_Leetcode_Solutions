/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let dic = new Map();
    
    for (let i = 0; i < nums.length; i++) {
        if (dic.has(nums[i])) {
            dic.set(nums[i], dic.get(nums[i]) + 1);
        } else {
            dic.set(nums[i], 1);
        }
    }

    for (let [key, value] of dic) {
        if (value > nums.length / 2) {
            return key;
        }
    }

    return -1;
};
