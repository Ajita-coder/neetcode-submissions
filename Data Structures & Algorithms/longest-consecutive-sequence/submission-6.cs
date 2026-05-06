public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet=new HashSet<int>(nums);
        int longsequence=0;
        foreach(int num in numSet)
        {   
            if(!numSet.Contains(num-1))
            { 
                int length=1;
                while(numSet.Contains(num+length))
                {
                      length++;
                }
              longsequence=Math.Max(longsequence,length);
            }

        }
        return longsequence;
    }
}
