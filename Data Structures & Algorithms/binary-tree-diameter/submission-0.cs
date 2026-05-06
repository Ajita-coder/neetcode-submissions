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
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root==null) return 0;
        int maxleft=MaxHeight(root.left);
        int maxright=MaxHeight(root.right);
        int Daimeter=maxleft+maxright;
        int sub=Math.Max(DiameterOfBinaryTree(root.left),DiameterOfBinaryTree(root.right));
        return Math.Max(Daimeter,sub);
    }
    public int MaxHeight(TreeNode root) 
    {
        if(root==null) return 0;
        return 1+ Math.Max(MaxHeight(root.left),MaxHeight(root.right));
     
    }
}
