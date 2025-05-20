/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private void Dfs(TreeNode node, List<int> leafList) {
        if (node == null) return;

        if (node.left == null && node.right == null) {
            leafList.Add(node.val);  // Add leaf node
            return;
        }

        Dfs(node.left, leafList);
        Dfs(node.right, leafList);
    }

    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> leaves1 = new List<int>();
        List<int> leaves2 = new List<int>();

        Dfs(root1, leaves1);
        Dfs(root2, leaves2);

        if (leaves1.Count != leaves2.Count) return false;

        for (int i = 0; i < leaves1.Count; i++) {
            if (leaves1[i] != leaves2[i]) return false;
        }

        return true;
    }
}