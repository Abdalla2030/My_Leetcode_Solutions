public class Solution {
    public int EqualPairs(int[][] grid) {
        int cnt = 0 ; 
        List<string> set = new List<string>();
        for(int i = 0;i<grid.Length;i++){
            StringBuilder sb = new StringBuilder("");
            for(int j = 0;j<grid[0].Length;j++){
                sb.Append(grid[i][j].ToString()+',');
            }
            set.Add(sb.ToString());
        }
        for(int i = 0;i<grid[0].Length;i++){
            StringBuilder sb = new StringBuilder("");
            for(int j = 0;j<grid.Length;j++){
                sb.Append(grid[j][i].ToString()+',');
            }
            int count = set.Count(x => x == sb.ToString());
            cnt += count;
        }

        return cnt;
    }
}