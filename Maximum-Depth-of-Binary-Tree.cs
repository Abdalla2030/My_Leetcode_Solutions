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

 // using BFS
public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null){
            return 0 ;
        }
        int level = 0 ;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0 ){
            int size = q.Count;
            for(int i = 0 ;i<size;i++){
                TreeNode cur = q.Dequeue();
                if(cur.left != null){
                    q.Enqueue(cur.left);
                }
                if(cur.right !=null){
                    q.Enqueue(cur.right);
                }
            }
            level += 1 ; 
        }
        return level;
    }
}