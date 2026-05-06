public class Solution {
      Dictionary<int, int> Results = new Dictionary<int, int>();

  public  string Encode(IList<string> strs)
  {
      StringBuilder encoded = new StringBuilder();
      int i = 0;
      int j = 1;
      foreach (string str in strs)
      {
           if (i== 0&& str.Length==0)
          {
              
              Results.Add(j*-1, str.Length);
              j++;
          }
          else
          {
              Results.Add(i, str.Length);
              
          }
          i += str.Length;
          
          encoded.Append(str);
      }
      return encoded.ToString();
  }

  public  List<string> Decode(string s)
  {
      List<string> decoded = new List<string>();
                
      foreach (var item in Results)
      {

          if (item.Value==0)
              decoded.Add("");
          else
              decoded.Add(s.Substring(item.Key, item.Value));                
      } 
      return decoded;
  }

    
}  
