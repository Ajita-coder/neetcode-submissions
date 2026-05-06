public class Solution {
    public int SingleNumber(int[] nums) {
          Dictionary<int, int> MapCount = new Dictionary<int, int>();
        foreach (int num in nums) {
        if (!MapCount.ContainsKey(num)) {
            MapCount[num] = 1;
        } else {
            MapCount[num]++;
        }
    }
        return MapCount.FirstOrDefault(n=>n.Value==1).Key;
    }
}
