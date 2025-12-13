1class TrieNode {
2    TrieNode[] children;  // 26 letters a-z
3    boolean isEnd;        // Marks the end of a word
4
5    TrieNode() {
6        children = new TrieNode[26];
7        isEnd = false;
8    }
9}
10class Trie {
11
12    private TrieNode root; 
13
14    public Trie() {
15        root = new TrieNode();
16    }
17    
18    public void insert(String word) {
19        TrieNode node = root;
20        for(char ch :  word.toCharArray()){
21            int index = ch - 'a';
22            if (node.children[index] == null) {
23                node.children[index] = new TrieNode(); // create if not exists
24            }
25            node = node.children[index];
26        }
27        node.isEnd = true;
28    }
29    
30    public boolean search(String word) {
31        TrieNode node = root;
32        for (char ch : word.toCharArray()) {
33            int index = ch - 'a';
34            if (node.children[index] == null) {
35                return false; // letter not found
36            }
37            node = node.children[index];
38        }
39        return node.isEnd;
40    }
41    
42    public boolean startsWith(String prefix) {
43        TrieNode node = root;
44        for (char ch : prefix.toCharArray()) {
45             int index = ch - 'a';
46            if (node.children[index] == null){
47                return false;
48            }
49            node = node.children[index];
50        }
51        return true; 
52    }
53}
54
55/**
56 * Your Trie object will be instantiated and called as such:
57 * Trie obj = new Trie();
58 * obj.insert(word);
59 * boolean param_2 = obj.search(word);
60 * boolean param_3 = obj.startsWith(prefix);
61 */