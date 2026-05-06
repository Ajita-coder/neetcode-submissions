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
    public int KthSmallest(TreeNode root, int k) {
        List<int> result=new List<int>();
        DFS(root,result);
        return result[k-1];
    }
     public void DFS(TreeNode root, List<int> result) {
        if(root==null) return;
        DFS(root.left,result);
        result.Add(root.val);
        DFS(root.right,result);        
    }
}
