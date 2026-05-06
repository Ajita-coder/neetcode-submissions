public class Solution {
    public int LengthOfLongestSubstring(string s) {
       HashSet<char> charSet=new HashSet<char>();
       int l=0;
       int res=0;
       for(int i=0;i<s.Length;i++)
       {
           while(charSet.Contains(s[i]))
           {
               charSet.Remove(s[l]);
               l++;
           }
           charSet.Add(s[i]);
           res=Math.Max(res,i-l+1);
       }
       return res;
    }
}
