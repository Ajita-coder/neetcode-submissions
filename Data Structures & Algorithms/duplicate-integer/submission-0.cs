public class Solution {
    public bool hasDuplicate(int[] nums) {


        Dictionary<int,int> Dictionaryarray =new Dictionary<int,int>();
       foreach(int num in nums)
        {
            if(Dictionaryarray.ContainsKey(num))
            {
                return true;
            }
            Dictionaryarray[num]=1;

        }
        
             return false;

    }
}
