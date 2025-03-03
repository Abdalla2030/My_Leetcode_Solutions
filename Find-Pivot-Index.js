/**
 * @param {number[]} nums
 * @return {number}
 */
var pivotIndex = function(nums) {
    let size = nums.length;
    let pre = new Array(size);
    let suff = new Array(size);
    pre[0] = nums[0];
    for(let i = 1;i<size;i++){
        pre[i] = nums[i] + pre[i-1];
    }
    suff[size-1] = nums[size-1];
    for(let i = size-2;i>=0;i--){
        suff[i] = nums[i] + suff[i+1];
    }
    for(let i = 0;i<size;i++){
        let leftSum = i === 0 ? 0 : pre[i - 1]; 
        let rightSum = i === size - 1 ? 0 : suff[i + 1]; 
        if (leftSum === rightSum) {
            return i; 
        }
    }
    return -1;
};