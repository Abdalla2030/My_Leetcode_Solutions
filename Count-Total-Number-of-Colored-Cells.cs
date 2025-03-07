public class Solution {
    public long ColoredCells(int n) {
        n--;
        return (1+(4*(((long)n*(n+1))/2)));
    }
}