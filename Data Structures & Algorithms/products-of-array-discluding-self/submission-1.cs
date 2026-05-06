public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
      

 int n = nums.Length;
 int[] output = new int[n];

 int Prefix = 1;
 for (int i = 0; i < n; i++)
 {
     output[i] = Prefix;
     Prefix *= nums[i];
 }
 int postfix = 1;
 for (int i = n-1; i>=0 ; i--)
 {
     output[i] *= postfix;
     postfix *= nums[i];
 }
return output;
    }
}
