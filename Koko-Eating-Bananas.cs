// Binary Search -- O(n * log(max(piles)))
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        long low = 1;
        long high = piles.Max();

        while (low <= high) {
            long k = (low + high) / 2;
            long hours = 0;

            foreach (int pile in piles) {
                hours += (long)Math.Ceiling((double)pile / k);
                if (hours > h) {
                    break; 
                }
            }

            if (hours <= h) {
                high = k - 1;
            } else {
                low = k + 1;
            }
        }

        return (int)low;
    }
}