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
    private int GCD(int a, int b) {
        return (b == 0) ? a : GCD(b, a % b);
    }
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if (head.next == null) {
            return head;
        }

        ListNode prev = head;
        ListNode curr = head.next;  

        while (curr != null) {
            int gcdValue = GCD(Math.Max(prev.val, curr.val), Math.Min(prev.val, curr.val));


            ListNode newNode = new ListNode(gcdValue);
            prev.next = newNode;
            newNode.next = curr;

            prev = curr;
            curr = curr.next;
        }

        return head;
    }
}