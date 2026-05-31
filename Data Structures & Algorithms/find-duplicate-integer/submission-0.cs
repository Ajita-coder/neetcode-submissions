public class Solution {
    public int FindDuplicate(int[] nums) {
//binary search
        int low =1;
        int high=nums.Length -1;
        while(low < high)
        {
            int mid=low+(high-low)/2;
            int lessOrEqual=0;
            for(int i=0;i<nums.Length;i++)
            {
                 if(nums[i]<=mid)
                 {
                    lessOrEqual++;
                 }
            }
            if(lessOrEqual<=mid)
            {
                low=mid+1;
            }
            else
            {
                high=mid;
            }
        }

        return low;
    }
}
