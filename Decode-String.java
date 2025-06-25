class Solution {
    public String decodeString(String s) {
        Stack<Integer> countStack = new Stack<>();
        Stack<StringBuilder> stringStack = new Stack<>();

        StringBuilder current = new StringBuilder();
        int k = 0;

         for (char c : s.toCharArray()) {
            if (Character.isDigit(c)) {
                k = k * 10 + (c - '0');  // for numbers
            } else if (c == '[') {
                countStack.push(k);
                stringStack.push(current);
                current = new StringBuilder();
                k = 0;
            }else if (c == ']') {
                int repeat = countStack.pop();
                StringBuilder last = stringStack.pop();
                for (int i = 0; i < repeat; i++) {
                    last.append(current);
                }
                current = last;
            }else {
                current.append(c);
            }
         }
          return current.toString();
    }
}