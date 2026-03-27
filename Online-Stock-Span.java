1class StockSpanner {
2
3    List<Integer> prices ;
4
5    public StockSpanner() {
6        prices = new ArrayList<>();
7    }
8    
9    public int next(int price) {
10        prices.add(price);
11        int res = 0 ; 
12        int i = prices.size() -1 ; 
13        while(i >= 0 && price >= prices.get(i)){
14            res++; 
15            i--; 
16        }
17        return res; 
18    }
19}
20
21/**
22 * Your StockSpanner object will be instantiated and called as such:
23 * StockSpanner obj = new StockSpanner();
24 * int param_1 = obj.next(price);
25 */