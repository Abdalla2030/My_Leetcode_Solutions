1class Solution {
2    public List<List<String>> suggestedProducts(String[] products, String searchWord) {
3
4        List<List<String>> result = new ArrayList<>();
5        List<String> productsList = Arrays.asList(products);
6
7        Arrays.sort(products);
8
9        for(int i = 0 ;i<searchWord.length();i++){
10            List<String> suggestions = new ArrayList<>();
11            String prefix = searchWord.substring(0, i+1);
12            int l = 0 ;
13            int r = products.length-1;
14
15            while(l<=r){
16                int mid = l + (r-l)/2 ;
17               if (prefix.compareTo(products[mid]) <= 0) {
18                    r = mid - 1;
19                } else {
20                    l = mid + 1;
21                }
22            }
23
24            for (int j = l; j < Math.min(l + 3, products.length); j++) {
25                if (products[j].startsWith(prefix)) {
26                    suggestions.add(products[j]);
27                } else {
28                    break;
29                }
30            }
31            result.add(suggestions);
32        }
33        return result;    
34    }
35}