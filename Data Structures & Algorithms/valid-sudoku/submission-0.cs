public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<String> seen=new HashSet<String>();
        for(int i=0;i<9;i++)
        {
           for(int j=0;j<9;j++)
            {
               char num=board[i][j];
               if(num !='.')
               {
                 if(!seen.Add(num+"in row"+i)||
                    !seen.Add(num+"in col"+j)||
                    !seen.Add(num+"in box"+i/3+"-"+j/3)
                    )
                 {
                    return false;
                 }
               }
            }
        }
        return true;
    }
}
