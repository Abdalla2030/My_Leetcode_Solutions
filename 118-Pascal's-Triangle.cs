public class Solution {
    public IList<IList<int>> Generate(int numRows) {
    IList<IList<int>> triangle = new List<IList<int>>();
    
    for (int i = 0; i < numRows; i++) {
        List<int> currentRow = new List<int>();
        for (int j = 0; j <= i; j++) {
            if (j == 0 || j == i) {
                currentRow.Add(1);
            } else {
                currentRow.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
            }
        }
        triangle.Add(currentRow);
    }
    
    return triangle;
}
}