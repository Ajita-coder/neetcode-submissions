public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l=1; 
        int r=piles.Max();
         int res=r;
        while(l<=r)
        {   int hour=0;
            int k=(l+r)/2;
            foreach(int pile in piles)
            {
                hour+=(int)Math.Ceiling((double)pile/k);
            }
            if(hour<=h)
            {
              res=k;
              r=k-1;
            }
            else
            {
                l=k+1;
            }
        }
        return res;
    }
}
