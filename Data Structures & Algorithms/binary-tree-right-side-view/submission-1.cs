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
    public List<int> RightSideView(TreeNode root) {
        if(root==null) return new List<int>();
        List<int> results=new List<int>();
        Queue<TreeNode> que=new Queue<TreeNode>();
        que.Enqueue(root);
        while(que.Count>0)
        {
            int levelsize=que.Count;
            for(int i=0;i<levelsize;i++)
            {  
                TreeNode node=que.Dequeue();
                if(i==levelsize-1)
               results.Add(node.val);
               if(node.left!=null)
               que.Enqueue(node.left);
               
                 if(node.right!=null)
               que.Enqueue(node.right);             

            }
        }
        return results;
    }
}
