public class Solution {
    public int MaxArea(int[] height) {
         int size = height.Length;
            int area = 0, maxArea = 0;
            int i = 0, j = size - 1;
            while (i<j)
            {
                area = Math.Min(height[i], height[j]) * (j - i);
                maxArea = Math.Max(maxArea, area);
                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return maxArea;
    }
}