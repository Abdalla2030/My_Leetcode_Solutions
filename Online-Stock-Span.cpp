1class StockSpanner {
2stack<pair<int,int>> st;
3public:
4    StockSpanner() {
5      
6    }
7    
8    int next(int price) {
9        int cnt = 1 ;
10        while(!st.empty() && price >= st.top().first){
11            cnt+= st.top().second; 
12            st.pop();
13        }
14        st.push({price, cnt});
15
16        return st.top().second;
17    }
18};
19
20/**
21 * Your StockSpanner object will be instantiated and called as such:
22 * StockSpanner* obj = new StockSpanner();
23 * int param_1 = obj->next(price);
24 */