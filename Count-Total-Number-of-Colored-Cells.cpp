class Solution {
public:
    long long coloredCells(int n) {
        long long arr[n+5];
        arr[1] = 1 ;
        int k = 4 ;
        for(int i = 2;i<=n;i++){
            arr[i] = arr[i-1] + k ;
            //cout<<arr[i]<<endl;
            k +=4 ;
        }
    return arr[n];
    }
};