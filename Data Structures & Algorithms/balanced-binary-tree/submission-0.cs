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
    public bool IsBalanced(TreeNode root) {
        if(root==null) return true;
        var maxleft=MaxHeight(root.left);
        var maxright=MaxHeight(root.right);
        if(Math.Abs(maxleft- maxright)>1) return false;
        return IsBalanced(root.left) && IsBalanced(root.right);        
    }
    public int MaxHeight(TreeNode root)
    {
        if(root==null) return 0;
        return 1 + Math.Max(MaxHeight(root.left),MaxHeight(root.right));

    }
}
