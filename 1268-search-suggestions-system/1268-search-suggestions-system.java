class Solution {
    public List<List<String>> suggestedProducts(String[] products, String searchWord) {

        List<List<String>> result = new ArrayList<>();
        List<String> productsList = Arrays.asList(products);

        Arrays.sort(products);

        for(int i = 0 ;i<searchWord.length();i++){
            List<String> suggestions = new ArrayList<>();
            String prefix = searchWord.substring(0, i+1);
            int l = 0 ;
            int r = products.length-1;

            while(l<=r){
                int mid = l + (r-l)/2 ;
               if (prefix.compareTo(products[mid]) <= 0) {
                    r = mid - 1;
                } else {
                    l = mid + 1;
                }
            }

            for (int j = l; j < Math.min(l + 3, products.length); j++) {
                if (products[j].startsWith(prefix)) {
                    suggestions.add(products[j]);
                } else {
                    break;
                }
            }
            result.add(suggestions);
        }
        return result;    
    }
}