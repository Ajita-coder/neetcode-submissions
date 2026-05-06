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
    private Dictionary<int,int> inorderIndex;
    private int preorderIndex=0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        inorderIndex=new Dictionary<int,int>();
        preorderIndex=0;
        for(int i=0;i<inorder.Length;i++)
        {
            inorderIndex[inorder[i]]=i;
        }
        return BuildSubTree(preorder,0,inorder.Length-1);
    }
    public TreeNode BuildSubTree(int[] preorder, int left, int right)
    {
        if(left>right) return null;
        int rootValue=preorder[preorderIndex++];
        TreeNode root=new TreeNode(rootValue);

        root.left=BuildSubTree(preorder,left,inorderIndex[rootValue]-1);
        root.right=BuildSubTree(preorder,inorderIndex[rootValue]+1,right);
    return root;
    }
}
