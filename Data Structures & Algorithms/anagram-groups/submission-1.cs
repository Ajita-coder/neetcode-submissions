public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<string>> anagramGroups=new Dictionary<string,List<string>>();

        foreach(string str in strs)
        {
            char[] charstr=str.ToCharArray();
            Array.Sort(charstr);   

            string sortedStr= new string(charstr); 

            // Use the sorted string as the key
            if (!anagramGroups.ContainsKey(sortedStr))
            {
                anagramGroups[sortedStr] = new List<string>();
            }

            anagramGroups[sortedStr].Add(str);
        }

        return anagramGroups.Values.ToList();        
    }
}
