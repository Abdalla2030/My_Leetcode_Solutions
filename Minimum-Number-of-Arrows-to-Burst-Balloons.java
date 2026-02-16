1class Solution {
2    public int findMinArrowShots(int[][] points) {
3        // sort points ascending based on xend for each point 
4        Arrays.sort(points, (a, b) -> Integer.compare(a[1], b[1]));
5
6        int ans = 1 ; 
7        int currentIntervalEnd = points[0][1];
8
9        for(int i = 1;i<points.length;i++){
10            if(points[i][0] > currentIntervalEnd){
11                currentIntervalEnd  = points[i][1];
12                ans++; 
13            }
14        }
15
16        return ans ; 
17    }
18}