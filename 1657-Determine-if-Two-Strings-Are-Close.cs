public class Solution {
    public bool CloseStrings(string word1, string word2) {

        if(word1.Length != word2.Length){
            return false ; 
        }

        int[] arr1 = new int[26];	
        int[] arr2 = new int[26];	
        
        for(int i = 0;i<word1.Length;i++){
            arr1[word1[i]-'a']++;
        }
        for(int i = 0;i<word2.Length;i++){
            arr2[word2[i]-'a']++;
        }

        for(int i = 0 ;i<26;i++){
            if((arr1[i]>0) != (arr2[i]>0)){
                return false;
            }
        }

        Array.Sort(arr1);
        Array.Sort(arr2);

        for(int i = 0 ;i<26;i++){
            if(arr1[i] != arr2[i]){
                return false; 
            }
        }


        return true; 

    }
}