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

 //O(N) space and timpe complexity
class Solution {
public:
    int pairSum(ListNode* head) {
        ListNode* slow = head;
        ListNode* fast = head; 
        ListNode* pre = nullptr; 
        ListNode* tmp = nullptr; 

        while(fast && fast->next){
            fast= fast->next->next;
            tmp = slow->next;
            slow->next = pre;
            pre = slow ; 
            slow = tmp;
        }

        int maxi = 0 ;
        while(slow){
            maxi = max(maxi,pre->val+slow->val);
            pre = pre->next;
            slow = slow->next;
        }

        return maxi ; 
    }
};