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
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        ListNode *h1 = l1;
        ListNode *h2 = l2;

        ListNode *result = new ListNode();
        ListNode *temp_result = result;

        int carry = 0 ; 
        while(h1 && h2){
            int output = h1->val + h2->val + carry ; 
            ListNode *new_node = new ListNode(output%10);
            carry = output / 10 ; 
            temp_result->next = new_node;
            temp_result = new_node;
            h1 = h1->next ;
            h2 = h2->next;
        }
        while(h1){
            int output = h1->val + carry ; 
            ListNode *new_node = new ListNode(output%10);
            carry = output / 10 ; 
            temp_result->next = new_node;
            temp_result = new_node;
            h1 = h1->next ;
        }
        while(h2){
            int output = h2->val + carry ; 
            ListNode *new_node = new ListNode(output%10);
            carry = output / 10 ; 
            temp_result->next = new_node;
            temp_result = new_node;
            h2 = h2->next;
        }

        if(carry){
            ListNode *new_node = new ListNode(carry);
            temp_result->next = new_node;
        }

        return result->next; 
    }
};