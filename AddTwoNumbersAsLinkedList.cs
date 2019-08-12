/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        if (l1 == null && l2 == null) {
            return null;
        }
       
        var currentNodeL1 = l1;
        var currentNodeL2 = l2;
        
        int carry = 0;
        ListNode firstNode = null;
        ListNode lastNode = null;
        while (currentNodeL1 != null || currentNodeL2 != null) {
            // get operands (checking if any of the numbers is greater in length than the other)
            var firstValue = currentNodeL1 != null ? currentNodeL1.val : 0;
            var secondValue = currentNodeL2 != null ? currentNodeL2.val : 0;
            
            // perform the sum
            var sum = firstValue + secondValue + carry;
            int sumDigit = sum % 10;
            carry = sum > 9 ? 1 : 0;
                    
            // save result
            var node = new ListNode(sumDigit);
            if (firstNode == null) {
                firstNode = node;
                lastNode = node;
            } else {                
                lastNode.next = node;
                lastNode = node;
            }
            
            // iterate to next node in each number
            currentNodeL1 = currentNodeL1 != null ? currentNodeL1.next : null;
            currentNodeL2 = currentNodeL2 != null ? currentNodeL2.next : null;
        }
        
        // if carry present, add it
        if (carry > 0){
            lastNode.next = new ListNode(carry);
        }
            
        return firstNode;
    }
}