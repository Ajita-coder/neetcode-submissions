public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            int[] array=new int[k];
    Dictionary<int, int> Results = new Dictionary<int, int>();
    for(int i= 0; i < nums.Length; i++)
{
        if (Results.ContainsKey(nums[i]))
        {
            Results[nums[i]]++;
        }
        if (!Results.ContainsKey(nums[i]))
        {
            Results[nums[i]] = 1;
        }
    }
      int count = 0;
  foreach (var n in Results.OrderByDescending(n => n.Value))
  {
      if(count < k)
      {
          array[count] = n.Key;
      }
      count++;
  }
  return array;
    }
}
