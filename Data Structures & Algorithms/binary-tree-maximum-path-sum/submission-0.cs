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
    int MaxSum=int.MinValue;//MinValue
    public int MaxPathSum(TreeNode root) {

        if(root==null) return 0;
        DFS(root);
        return MaxSum;
    }
    public int DFS(TreeNode root)
    {
        if(root==null) return 0;
        int leftMax=0,rightMax=0;
        leftMax=Math.Max(0,DFS(root.left));
        rightMax=Math.Max(0,DFS(root.right));

        MaxSum=Math.Max(MaxSum,(leftMax+rightMax+root.val));

      return Math.Max(leftMax,rightMax)+root.val;
    }
}
