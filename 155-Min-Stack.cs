public class MinStack {
    Stack <int> st ; 
    Stack <int> min_st ; 

    public MinStack() {
        st  = new Stack<int>();
        min_st = new Stack<int>();
    }
    
    public void Push(int val) {
        st.Push(val);

        if(min_st.Count==0){
            min_st.Push(val);
        }else{
            min_st.Push(Math.Min(min_st.Peek(),val));
        }
    }
    
    public void Pop() {
        st.Pop();
        min_st.Pop();
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return min_st.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */