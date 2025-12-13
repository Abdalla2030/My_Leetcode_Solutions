1class Solution {
2    public int eraseOverlapIntervals(int[][] intervals) {
3       Arrays.sort(intervals, (a, b) -> Integer.compare(a[1], b[1]));
4
5       int removed = 0 ;
6       int last = intervals[0][1];
7
8       for(int i = 1;i<intervals.length ;i++){
9        if(intervals[i][0]>= last){
10            last = intervals[i][1];
11        }else{
12            removed++; 
13        }
14       }
15        return removed;
16    }
17}