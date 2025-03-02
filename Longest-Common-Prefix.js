/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
     let ans = \\;
    for (let i = 0; i < strs[0].length; i++) {
        let c = strs[0][i];
        for (let j = 1; j < strs.length; j++) {
            if (i >= strs[j].length || strs[j][i] !== c) {
                return ans;
            }
        }
        ans += strs[0][i];
    }
    return ans;
};