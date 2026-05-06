public class Solution {
    public int[] TwoSum(int[] nums, int target) {

  Dictionary<int,int>  indexsum=new Dictionary<int,int>();
  for(int i=0;i<nums.Length;i++)
  {
     int sum =target- nums[i];
     if(indexsum.ContainsKey(sum))
     {
        return new int[]{indexsum[sum],i};
     }
     if(!indexsum.ContainsKey(nums[i]))
     {
        indexsum[nums[i]]=i;
     }

  }

return new int[]{-1,-1};

    }
}
