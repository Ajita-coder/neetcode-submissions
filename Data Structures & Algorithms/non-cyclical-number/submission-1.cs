public class Solution {
    public bool IsHappy(int n) {

        int slow=n;
        int fast=SquareOfSum(n);
        while(slow != fast)
        {
            fast=SquareOfSum(fast);
            fast=SquareOfSum(fast);
            slow=SquareOfSum(slow);
        }
        return fast==1;
    }
    public int SquareOfSum(int n)
    {    int output=0;
         while(n!=0)
         {
            output +=(n%10)* (n%10);
            n/=10;
         }
         return output;
    }
}
