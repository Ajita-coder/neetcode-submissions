public class Solution {
    public int Trap(int[] height) {
        if(height==null || height.Length==0) return 0;
        int left=0;
        int right=height.Length-1;
        int leftMax=0,rightMax=0;
        int trapwater=0;
        while(left<right)
        {
            if(height[left]<height[right])
            {
                if(height[left]>=leftMax)
                {
                    leftMax=height[left];
                }
                else
                {
                    trapwater+=leftMax -height[left];
                    
                }
                left++;
            }
            else
            {
               if(height[right]>=rightMax)
                {
                    rightMax=height[right];
                }
                else
                {
                    trapwater+=rightMax -height[right];
                  
                }
                  right--;
            }


        }
        return trapwater;
    }
}
