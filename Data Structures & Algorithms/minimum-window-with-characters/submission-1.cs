public class Solution {
      public  string MinWindow(string s, string t)
   {
       if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length)
           return "";
       Dictionary<char, int> dicRequired = new Dictionary<char, int>();
       for (int i = 0; i < t.Length; i++)
       {
           char c = t[i];
           if (!dicRequired.ContainsKey(c))
           {
               dicRequired[c] = 0;
           }
           dicRequired[c]++;
       }
       Dictionary<char, int> dicHave = new Dictionary<char, int>();
       int left = 0;
       int right = 0;
       int Minlength = int.MaxValue;
       int count = 0;
       int start = 0;
       while (right < s.Length)
       {
           char c = s[right];
           right++;
           if (dicRequired.ContainsKey(c))
           {
               if (!dicHave.ContainsKey(c))
                   dicHave[c] = 0;
               dicHave[c]++;

               if (dicHave[c] == dicRequired[c])                      
               count++;
           }
           while (count == dicRequired.Count)
           {
               if (right - left < Minlength)
               {
                   
                   Minlength = right - left;
                   start =left;
               }

               char d = s[left];
               left++;

               if (dicRequired.ContainsKey(d))
               {
                   if (dicHave[d] == dicRequired[d])
                       count--;
                   dicHave[d]--;
               }

           }
          
       }
       return Minlength == int.MaxValue ? "" : s.Substring(start, Minlength);
   }    
}
