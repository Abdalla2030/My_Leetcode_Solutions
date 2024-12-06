public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                if (stack.Peek() == '{' && c != '}'||
                    stack.Peek() == '[' && c != ']' ||
                    stack.Peek() == '(' && c != ')'){
                    return false;
                }else{
                    stack.Pop(); 
                }
                
            
            }
        }
        return stack.Count == 0;
    }
}