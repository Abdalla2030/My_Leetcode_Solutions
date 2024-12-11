public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> sol = new List<IList<int>>();
        Array.Sort(nums); // Sort the array first

        for (int i = 0; i < nums.Length; i++) {
            // Skip duplicates for the first element
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue; 
            }

            int l = i + 1, r = nums.Length - 1;
            while (l < r) {
                int sum = nums[i] + nums[l] + nums[r]; 
                if (sum == 0) {
                    sol.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    r--;

                    // Skip duplicates for the second element
                    while (l < r && nums[l] == nums[l - 1]) l++;
                    // Skip duplicates for the third element
                    while (l < r && nums[r] == nums[r + 1]) r--;
                } 
                else if (sum > 0) {
                    r--;
                } else {
                    l++;
                }
            }
        }
        return sol; 
    }
}
