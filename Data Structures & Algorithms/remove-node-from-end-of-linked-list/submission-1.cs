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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        // ListNode dummy = new ListNode(0, head);
        // ListNode left = dummy;
        // ListNode right = head;

        // while (n > 0) 
        // {
        //     right = right.next;
        //     n--;
        // }

        // while (right != null) 
        // {
        //     left = left.next;
        //     right = right.next;
        // }

        // left.next = left.next.next;
        // return dummy.next;

        int N = 0;
        ListNode cur = head;

        while (cur != null) 
        {
            N++;
            cur = cur.next;
        }

        int removeIndex = N - n;

        if (removeIndex == 0) 
        {
            return head.next;
        }

        cur = head;

        for (int i = 0; i < N - 1; i++) 
        {
            if (i + 1 == removeIndex) 
            {
                cur.next = cur.next.next;
                break;
            }

            cur = cur.next;
        }
        
        return head;
    }
}
