public class Solution {
    public int[] PlusOne(int[] digits) {
        bool flag=false;
        for(int i=digits.Length-1;i>=0;i--)
        {
            if(flag==false)
            {
            
                if(digits[i]==9)
                {
                  digits[i]=0;
                }
                else
                {
                 digits[i]++; flag=true;
                }
                               
            }
        }
        if(!flag)
        {
         int[] result = new int[digits.Length + 1];
            result[0] = 1;
            for (int j = 0; j < digits.Length; j++) {
                result[j + 1] = digits[j];
            }
            return result;   
        }
        return digits;
    }
}
