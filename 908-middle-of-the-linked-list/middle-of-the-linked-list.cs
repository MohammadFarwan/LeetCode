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
    public ListNode MiddleNode(ListNode head) {
        ListNode First_ptr = head , second_ptr = head;
        while(First_ptr != null && First_ptr.next != null){
            second_ptr = second_ptr.next;
            First_ptr = First_ptr.next.next;
        }
        return second_ptr ;
    }
}