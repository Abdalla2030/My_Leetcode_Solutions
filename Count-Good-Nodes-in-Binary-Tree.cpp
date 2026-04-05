1/**
2 * Definition for a binary tree node.
3 * struct TreeNode {
4 *     int val;
5 *     TreeNode *left;
6 *     TreeNode *right;
7 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
8 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
9 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
10 * };
11 */
12class Solution {
13public:
14
15    int dfs(TreeNode* node, int currentMax){
16
17        if (node == nullptr) return 0;
18
19        int isGood = (node->val >= currentMax) ? 1 : 0;
20
21        return isGood + 
22        dfs(node->left, max(currentMax,node->val)) + 
23        dfs(node->right, max(currentMax,node->val)) ; 
24    }
25
26    int goodNodes(TreeNode* root) {
27      return dfs(root,root->val);
28    }
29};