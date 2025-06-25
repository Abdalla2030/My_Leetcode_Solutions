class Solution {
public:
    string decodeString(string s) {
        stack<int> countStack;
        stack<string> stringStack;
        string current = "";
        int k = 0;

        for (char c : s) {
            if (isdigit(c)) {
                k = k * 10 + (c - '0');
            }
            else if (c == '[') {
                countStack.push(k);
                stringStack.push(current);
                current = "";
                k = 0;
            }
            else if (c == ']') {
                int repeat = countStack.top(); countStack.pop();
                string prev = stringStack.top(); stringStack.pop();
                string temp = "";
                for (int i = 0; i < repeat; i++) {
                    temp += current;
                }
                current = prev + temp;
            }
            else {
                current += c;
            }
        }

        return current;
    }
};