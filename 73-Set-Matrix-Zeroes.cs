public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[][] matrix2 = new int[m][];

        for (int i = 0; i < m; i++)
        {
            matrix2[i] = new int[n];
            Array.Copy(matrix[i], matrix2[i], n);
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    for (int k = 0; k < m; k++)
                    {
                        matrix2[k][j] = 0;
                    }
                    for (int l = 0; l < n; l++)
                    {
                        matrix2[i][l] = 0;
                    }
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix2[i][j] != 0)
                {
                    matrix2[i][j] = matrix[i][j];
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            Array.Copy(matrix2[i], matrix[i], n);
        }
    }
}
