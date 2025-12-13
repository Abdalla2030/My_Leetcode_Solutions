1class Solution {
2public:
3    vector<vector<string>> suggestedProducts(vector<string>& products, string searchWord) {
4        sort(products.begin(), products.end());
5        vector<vector<string>> result;
6
7        for(int i = 0 ;i<searchWord.size();i++){
8            string pre = searchWord.substr(0,i+1);
9            vector<string> res;
10            for(string product : products){
11                if(product.compare(0, pre.size(), pre) == 0){
12                    res.push_back(product);
13
14                    if(res.size()==3){
15                        break; 
16                    }
17                }
18            }
19            result.push_back(res);
20        }
21
22        return result; 
23    }
24};