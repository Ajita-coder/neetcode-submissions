public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map=new Dictionary<int,int>();
         int[] array=new int[k];
        foreach(int i in nums)
        {
              if(!map.ContainsKey(i))
              {
                map[i]=1;
              }
              else
              {
                map[i]++;
              }
        }
        int count=0;
         foreach (var n in map.OrderByDescending(n => n.Value))
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
