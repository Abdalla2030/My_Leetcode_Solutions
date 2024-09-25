public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++) {
            IList<int> r = new List<int>(i + 1);
            r.Add(1);

            for (int j = 1; j < i; j++) {
                r.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
            }

            if (i > 0) {
                r.Add(1);
            }

            triangle.Add(r);
        }

        return triangle;
    }
}
