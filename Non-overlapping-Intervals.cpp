1class Solution {
2public:
3    bool static myComparator(const vector<int>& a, const vector<int>& b) {
4        return a[0] < b[0];
5    }
6    int eraseOverlapIntervals(vector<vector<int>>& intervals) {
7
8        sort(intervals.begin(), intervals.end(), myComparator);
9        int count = 0 ; 
10        int pre = intervals[0][1];
11        for(int i = 1;i<intervals.size();i++){
12            if(intervals[i][0]>=pre){
13                pre = intervals[i][1];
14            }else{
15                count++;  
16                pre = min(pre, intervals[i][1]);
17            }
18        }
19        return count; 
20    }
21};