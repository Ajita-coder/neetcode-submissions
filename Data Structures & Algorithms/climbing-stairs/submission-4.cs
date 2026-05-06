public class Solution {
    public int ClimbStairs(int n) { 
        int[] memo = new int[n + 1];
        return Dfs(n, 0, memo);
    }
    public int Dfs(int n, int i, int[] memo)
    {
            if(i >= n) return i == n ? 1 : 0;
            if(memo[i] > 0) return memo[i];
            return memo[i] = Dfs(n, i + 1, memo) + Dfs(n, i + 2, memo);
    }
}