1class Solution {
2    public int[] dailyTemperatures(int[] temperatures) {
3        Stack<Integer> stack = new Stack<>();
4        int[] result = new int[temperatures.length];
5
6        for(int i=0 ; i<temperatures.length ; i++){
7            while(!stack.isEmpty() && temperatures[i] > temperatures[stack.peek()]){
8                int prevIndex = stack.pop();
9                result[prevIndex] = i - prevIndex;
10            }
11            stack.push(i);
12        }
13
14        return result; 
15    }
16}