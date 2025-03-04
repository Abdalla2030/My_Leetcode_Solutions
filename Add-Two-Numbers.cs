/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode h1 = l1 ;
        ListNode h2 = l2 ;

        ListNode res = new ListNode();
        ListNode temp = res ;
        int carry = 0 ;
        while(h1 != null || h2 != null || carry != 0 ){
           int sum = carry;

            if (h1 != null) {
                sum += h1.val;
                h1 = h1.next;
            }

            if (h2 != null) {
                sum += h2.val;
                h2 = h2.next;
            }

            carry = sum / 10;

            temp.next = new ListNode(sum % 10);
            temp = temp.next;
        }
        res = res.next;
        return res ; 
    }
}