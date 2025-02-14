public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
       IList<IList<int>> res = new List<IList<int>> { new List<int>(), new List<int>() };

        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        
        foreach (int num in set1) {
            if (!set2.Contains(num)) {
                res[0].Add(num);
            }
        }


        foreach (int num in set2) {
            if (!set1.Contains(num)) {
                res[1].Add(num);
            }
        }

        return res; 

    }
}