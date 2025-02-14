var findDifference = function(nums1, nums2) {
    let res = [[], []]; 

    let set1 = new Set(nums1);
    let set2 = new Set(nums2);

    for (let num of set1) {
        if (!set2.has(num)) {
            res[0].push(num);
        }
    }

    for (let num of set2) {
        if (!set1.has(num)) {
            res[1].push(num);
        }
    }

    return res;
};
