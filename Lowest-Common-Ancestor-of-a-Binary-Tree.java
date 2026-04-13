1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     int val;
5 *     TreeNode left;
6 *     TreeNode right;
7 *     TreeNode(int x) { val = x; }
8 * }
9 */
10class Solution {
11    public TreeNode dfs(TreeNode node, TreeNode p, TreeNode q) {
12        if (node == null) return null;
13
14        if(node == p || node == q){
15            return node; 
16        }
17
18        TreeNode left =  dfs(node.left,p,q);
19        TreeNode right =  dfs(node.right,p,q);
20
21        if(left !=null && right != null ){
22            return node;
23        }
24
25         if (left != null) {
26            return left;
27        }
28
29        return right;
30    }
31
32    public TreeNode lowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
33        return dfs(root,p,q);
34    }
35}