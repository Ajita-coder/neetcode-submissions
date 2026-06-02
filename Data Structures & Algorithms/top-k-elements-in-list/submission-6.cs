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
 PriorityQueue<int,int> heap=new PriorityQueue<int,int>();
  foreach (var entry in Results)
  {
          heap.Enqueue(entry.Key,entry.Value);
      if(heap.Count > k)
      {
         heap.Dequeue();
          }
      
  }
 var res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = heap.Dequeue();
        }
        return res;
 }
}
