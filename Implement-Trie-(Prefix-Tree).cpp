1struct TrieNode {
2    TrieNode* children[26]; // 26 lowercase letters
3    bool isEnd;
4
5    TrieNode() {
6        for (int i = 0; i < 26; i++)
7            children[i] = nullptr;
8        isEnd = false;
9    }
10};
11class Trie {
12
13private:
14    TrieNode* root;
15public:
16    Trie() {
17        root = new TrieNode();
18 
19    }
20    
21    void insert(string word) {
22        TrieNode* node = root;
23        for (char ch : word) {
24            int index = ch - 'a';
25            if (node->children[index] == nullptr) {
26                node->children[index] = new TrieNode();
27            }
28            node = node->children[index];
29        }
30        node->isEnd = true;
31    }
32    
33    bool search(string word) {
34        TrieNode* node = root;
35        for (char ch : word) {
36            int index = ch - 'a';
37            if (node->children[index] == nullptr)
38                return false;
39            node = node->children[index];
40        }
41        return node->isEnd;
42    }
43    
44    bool startsWith(string prefix) {
45        TrieNode* node = root;
46        for (char ch : prefix) {
47            int index = ch - 'a';
48            if (node->children[index] == nullptr)
49                return false;
50            node = node->children[index];
51        }
52        return true;
53    }
54};
55
56/**
57 * Your Trie object will be instantiated and called as such:
58 * Trie* obj = new Trie();
59 * obj->insert(word);
60 * bool param_2 = obj->search(word);
61 * bool param_3 = obj->startsWith(prefix);
62 */