public class Solution {
    public string RemoveStars(string s) {
        Stack<char> st = new Stack<char>();

        foreach(char c in s){
            if(c != '*'){
                st.Push(c);
            }else{
                st.Pop();
            }
        }

        StringBuilder sb = new StringBuilder();

        while (st.Count > 0)
        {
            sb.Append(st.Pop());
        }


        return new string (sb.ToString().Reverse().ToArray());


    }
}