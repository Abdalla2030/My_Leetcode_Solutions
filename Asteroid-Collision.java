class Solution {
    public int[] asteroidCollision(int[] asteroids) {
        Stack<Integer> stack = new Stack<>();

         for (int a : asteroids) {
            boolean alive = true;

            while (!stack.isEmpty() && a < 0 && stack.peek() > 0){
                if (Math.abs(a) > stack.peek()) {
                    stack.pop(); // remove top positive from stack 
                }else if (Math.abs(a) == stack.peek()) {
                    stack.pop(); // pos = neg -> two will removed
                    alive = false;
                    break;
                }else {
                    alive = false; // neg removed
                    break;
                }
            }
            if (alive) { // neg added to stack -> if not removed 
                stack.push(a);
            }
        }
        // convert stack to array
        int[] result = new int[stack.size()];
        for (int i = stack.size() - 1; i >= 0; i--) {
            result[i] = stack.pop();
        }

        return result;
    }
}