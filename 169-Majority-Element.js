/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let res = mag = 0 ;
    for(let i = 0 ;i<nums.length;i++){
        if(mag==0){
            res = nums[i];
        }
        if(nums[i]==res){
            mag++;
        }else{
            mag--;
        }
    }
    return res ; 
}