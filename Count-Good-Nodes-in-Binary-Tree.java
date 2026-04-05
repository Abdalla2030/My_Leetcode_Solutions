1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     int val;
5 *     TreeNode left;
6 *     TreeNode right;
7 *     TreeNode() {}
8 *     TreeNode(int val) { this.val = val; }
9 *     TreeNode(int val, TreeNode left, TreeNode right) {
10 *         this.val = val;
11 *         this.left = left;
12 *         this.right = right;
13 *     }
14 * }
15 */
16class Solution {
17    int cnt = 0 ;
18
19    void dfs(TreeNode node, int currentMax) {
20        if (node == null) return;
21
22        if(node.val >= currentMax){
23            cnt++; 
24        }
25
26        currentMax = Math.max(node.val,currentMax);
27
28        dfs(node.left,currentMax);
29        dfs(node.right,currentMax);
30    }
31
32    public int goodNodes(TreeNode root) { 
33        dfs(root, root.val);
34        return cnt;
35    }
36}