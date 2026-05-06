public class TrieNode
{
    public Dictionary<char,TrieNode>  Children {get;set;}
    public bool IsEndOfWord {get;set;}
    public TrieNode()
    {
       Children =new Dictionary<char,TrieNode>();
       IsEndOfWord=false;
    }
    
}
public class WordDictionary {
     private readonly TrieNode root;
    public WordDictionary() {

        root=new TrieNode();
    }
    
    public void AddWord(string word) {
        var node=root;
        foreach(char ch in word)
        {
            if(!node.Children.ContainsKey(ch))
            {
                node.Children[ch]=new TrieNode();
            }
            node=node.Children[ch];
        }
        node.IsEndOfWord=true;
    }
    public bool Search(string word) {
       
      return  SearchTrie(word,0,root);
        
    }
    
    public bool SearchTrie(string word,int index,TrieNode node) {
        
        if(word.Length==index)
        {
            return node.IsEndOfWord;
        }
         
         var ch=word[index];
         if(ch=='.')
         {
            foreach(var child in node.Children.Values)
            {
                  if(SearchTrie(word,index+1,child))
                  {
                       return true;
                  }
            }
            return false;
         }
        else
        {
            if(!node.Children.ContainsKey(ch))
            {
               return false;
            }
             return SearchTrie(word,index+1,node.Children[ch]);
        }
       
    }
}
