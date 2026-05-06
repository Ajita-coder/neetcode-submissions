public class TreeNode {
    public Dictionary<char,TreeNode> Children=new Dictionary<char,TreeNode>();
    public bool IsEndOfTree=false;
}



public class PrefixTree {
  private readonly TreeNode root;
    public PrefixTree() {
        root=new TreeNode();           
    }
    
    public void Insert(string word) {
        var node=root;
        foreach(char c in word)
        {
            if(!node.Children.ContainsKey(c))
            {
                node.Children[c]=new TreeNode();
            }
            node=node.Children[c];
        }
        node.IsEndOfTree=true;        
    }
    
    public bool Search(string word) {
        var node=root;
        foreach(char c in word)
        {
            if(!node.Children.ContainsKey(c))
            {
               return false;
            }
            node=node.Children[c];

        }
        return node.IsEndOfTree;
    }
    
    public bool StartsWith(string prefix) {
        var node=root;
        foreach(char c in prefix)
        {
            if(!node.Children.ContainsKey(c))
            {
               return false;
            }
          node = node.Children[c];
        }
        return true;        
    }
   
}
