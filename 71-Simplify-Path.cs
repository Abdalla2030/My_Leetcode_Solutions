public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> st = new Stack<string>();
        foreach(string dir in path.Split('/')){
            if(dir.Length==0 || dir.Equals(\.\)){
                continue; 
            }else if(dir.Equals(\..\)){
                if(st.Count>0){
                    st.Pop();
                }
            }else{
                st.Push(dir);
            }
        }
        StringBuilder res = new StringBuilder();
        foreach(string dir in st.Reverse()){
            res.Append(\/\).Append(dir);
        }

        return res.Length>0 ? res.ToString() : \/\;
    }
}