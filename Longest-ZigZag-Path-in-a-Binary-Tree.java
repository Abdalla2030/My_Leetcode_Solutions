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
17    public int maxi = 0 ; 
18
19    public void dfs(TreeNode root,String dir,int cnt){
20
21        if(root == null) return;
22
23        maxi = Math.max(maxi,cnt); 
24
25        if (dir.equals("left")) {
26            dfs(root.right, "right", cnt + 1); // continue
27            dfs(root.left, "left", 1);         // restart
28        } else {
29            dfs(root.left, "left", cnt + 1);   // continue
30            dfs(root.right, "right", 1);       // restart
31        }
32
33    }
34
35    public int longestZigZag(TreeNode root) {
36        dfs(root, "left", 0);
37        dfs(root, "right", 0);
38        return maxi ; 
39    }
40}