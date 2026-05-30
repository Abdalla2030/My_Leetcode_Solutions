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
17    public int count(TreeNode node,long remaining){
18    
19        if(node == null){
20            return 0 ; 
21        }
22        int current = remaining - node.val == 0 ? 1 : 0 ; 
23        return current + 
24               count(node.left,remaining-node.val) +
25               count(node.right,remaining-node.val); 
26    }
27    public int pathSum(TreeNode root, int targetSum) {
28
29        if (root == null){
30            return 0 ; 
31        }
32
33        return count(root, targetSum) + 
34               pathSum(root.left, targetSum) + 
35               pathSum(root.right, targetSum)  ; 
36    }
37}