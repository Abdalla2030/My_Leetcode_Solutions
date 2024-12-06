public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();

        foreach(string s in tokens){
            if(s != \+\ && s != \-\ && s != \*\ && s != \/\){
                int x = int.Parse(s);
                st.Push(x);
            }else{
                int x = st.Pop();
                int y = st.Pop();
                int res;
                switch(s){
                    case \+\:
                        res = x+y;
                        st.Push(res);
                        break ; 
                    case \-\:
                        res = y-x;
                        st.Push(res);
                        break;
                    case \*\:
                        res = x*y ; 
                        st.Push(res);
                        break;
                    default:
                        res = y/x;
                        st.Push(res);
                        break; 

                }
            }
        }
        return st.Peek();
    }
}