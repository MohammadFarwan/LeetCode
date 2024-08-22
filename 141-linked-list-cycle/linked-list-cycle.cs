/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visited = new HashSet<ListNode>();
        
        while (head != null) {
            if (visited.Contains(head)) {
                return true; // Cycle detected
            }
            
            visited.Add(head);
            head = head.next;
        }
        
        return false; // No cycle found
    }
}