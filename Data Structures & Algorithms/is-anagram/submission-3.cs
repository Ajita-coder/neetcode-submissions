public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
         Dictionary<char,int> CharIndex=new Dictionary<char,int>();
         foreach(var c in s)
         {
            if(CharIndex.ContainsKey(c))
            CharIndex[c]++;
            else
            CharIndex[c]=1;
         }
         foreach(var c in t)
         {
            if(!CharIndex.ContainsKey(c) || CharIndex[c]==0)
            return false;
            CharIndex[c]--;

         }
          return true;
    }
}
