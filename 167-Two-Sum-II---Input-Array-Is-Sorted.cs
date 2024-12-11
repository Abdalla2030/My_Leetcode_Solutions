public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0 , j = numbers.Length-1;
        while(i<j){
            if(numbers[i]+numbers[j]==target){
                break; 
            }
            if(numbers[i]+numbers[j]<target){
                i++;
            }else{
                j--; 
            }
        }
        return new int[2]{i+1,j+1};
    }
}