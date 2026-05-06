public class Solution {
    public bool hasDuplicate(int[] nums) {

        Dictionary<int,int> DicMap=new Dictionary<int,int>();
         foreach(int num in nums)
         {
            if(DicMap.ContainsKey(num))
            {
              return true;
            }
             DicMap[num]=1;
         }
         return false;
        
    }
}