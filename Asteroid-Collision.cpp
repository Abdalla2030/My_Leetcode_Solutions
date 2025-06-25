class Solution {
public:
    vector<int> asteroidCollision(vector<int>& asteroids) {
        stack<int> st;

        for (int a : asteroids) {
            bool alive = true;

            while (alive && !st.empty() && a < 0 && st.top() > 0) {
                if (abs(a) > st.top()) {
                    st.pop();  
                } else if (abs(a) == st.top()) {
                    st.pop(); 
                    alive = false;
                } else {
                    alive = false;  
                }
            }

            if (alive) {
                st.push(a);
            }
        }

        vector<int> result(st.size());
        for (int i = st.size() - 1; i >= 0; i--) {
            result[i] = st.top();
            st.pop();
        }

        return result;
    }
};