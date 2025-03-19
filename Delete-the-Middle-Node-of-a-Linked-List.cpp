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
    ListNode* deleteMiddle(ListNode* head) {
        if(head->next == nullptr){
            return nullptr;
        }
        ListNode* start = head;
        ListNode* end = head;
        int cnt = 0 ;
        while(end->next != nullptr){
            end = end->next;
            cnt++;
        }
        int k = 0 ;
        cnt%2==0? cnt=(cnt/2):cnt=(cnt/2)+1;
       // cout<<cnt<<endl;
        while(k<cnt-1){
            k++;
            start = start->next;
        }
        start->next = start->next->next ; 
        return head;

    }
};