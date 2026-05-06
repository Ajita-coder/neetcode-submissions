public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int n = nums.Length;
int[] output = new int[n];

// Step 1: Compute prefix product
output[0] = 1;
for (int i = 1; i < n; i++)
{
    output[i] = output[i - 1] * nums[i - 1];
}

// Step 2: Compute suffix product and update output array
int suffixProduct = 1;
for (int i = n - 1; i >= 0; i--)
{
    output[i] *= suffixProduct;
    suffixProduct *= nums[i];
}

return output;
    }
}
