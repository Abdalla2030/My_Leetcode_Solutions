/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
    int GCD(int a,int b){
        if(b==0){
            return a;
        }
        return GCD(b,a%b);
    }
public:
    ListNode* insertGreatestCommonDivisors(ListNode* head) {
        if(head->next == nullptr){
            return head;
        }
        ListNode* prev = head;
        ListNode* curr = head->next;
        while(prev && curr){
            int output = GCD(max(prev->val,curr->val),min(prev->val,curr->val));

            ListNode* new_node = new ListNode(output);
            prev->next= new_node;
            new_node ->next = curr; 

            prev = curr;
            curr = curr->next;
        }
    return head ; 
    }
};