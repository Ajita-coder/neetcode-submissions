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
     List<List<int>> LevelList=new List<List<int>>();
    public List<List<int>> LevelOrder(TreeNode root) {       
           dfs(root,0);
           return LevelList;        
    }
    private void dfs(TreeNode node, int depth) {
        if (node == null) {
            return;
        }
        
        if (LevelList.Count == depth) {
            LevelList.Add(new List<int>());
        }
        
        LevelList[depth].Add(node.val);
        dfs(node.left, depth + 1);
        dfs(node.right, depth + 1);
    }
}
