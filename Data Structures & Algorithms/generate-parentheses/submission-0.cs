public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        //open add if openP <n
        //close add if closeP <openP
        //stop adding if closeP==openP==n
        List<string> res=new List<string>();
        string stack="";
        Backtrack(0,0,n,res,stack);
        return res;
    }
    public void Backtrack(int openP,int closeP,int n,List<string> res,string stack)
    {
        if(openP==closeP && openP==n)
        {
               res.Add(stack);
               return;
        }
     

        if(openP < n)
        {
           Backtrack(openP + 1,closeP,n,res,stack+'(');
        }
        if(closeP < openP)
        {
            Backtrack(openP,closeP + 1,n,res,stack+')');
        }
    }
}
