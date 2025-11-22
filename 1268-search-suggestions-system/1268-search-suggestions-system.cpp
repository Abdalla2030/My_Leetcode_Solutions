class Solution {
public:
    vector<vector<string>> suggestedProducts(vector<string>& products, string searchWord) {
        sort(products.begin(), products.end());
        vector<vector<string>> result;

        for(int i = 0 ;i<searchWord.size();i++){
            string pre = searchWord.substr(0,i+1);
            vector<string> res;
            for(string product : products){
                if(product.compare(0, pre.size(), pre) == 0){
                    res.push_back(product);

                    if(res.size()==3){
                        break; 
                    }
                }
            }
            result.push_back(res);
        }

        return result; 
    }
};