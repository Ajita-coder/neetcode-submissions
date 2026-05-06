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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
         if(root==null) return "N";
        List<string> result=new List<string>();
        Queue<TreeNode> que=new Queue<TreeNode>();
        que.Enqueue(root);
        while(que.Count()>0)
        {
            TreeNode node=que.Dequeue();
            if(node==null)
            {
                 result.Add("N");
            }
            else
            {
                 result.Add(node.val.ToString());
                 que.Enqueue(node.left);
                 que.Enqueue(node.right);
            }
        }
        return string.Join(",",result);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if(data=="N") return null;
       string[] result=data.Split(',');
       Queue<TreeNode> que=new Queue<TreeNode>();
       TreeNode root=new TreeNode(int.Parse(result[0]));
       que.Enqueue(root);
       int i=1;
        while(que.Count()>0)
        {
            TreeNode node=que.Dequeue();
            if(result[i]!="N")
            {
               node.left=new TreeNode(int.Parse(result[i]));
               que.Enqueue(node.left);
            }
             i++;
             if(result[i]!="N")
            {
               node.right=new TreeNode(int.Parse(result[i]));
               que.Enqueue(node.right);
            }
             i++;

        }
        return root;
    }
}
