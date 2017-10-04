
using System;

namespace algorithms
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    public class Solution002
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
        }

        public ListNode AddTwoNumbers(ListNode L1, ListNode L2)
        {
            ListNode headNode = new ListNode(0);
            ListNode current = headNode;
            int carry = 0;

            // Advance through the lists if not exhausted.
            while (L1 != null || L2 != null)
            {

                // Get the values from the input nodes. 0 if null.
                int x = (L1 != null) ? L1.val : 0;
                int y = (L2 != null) ? L2.val : 0;

                // Sum the node values and carry value.
                int sum = carry + x + y;

                // Compute the carry through int division by 10.
                carry = sum / 10;

                // Store the ones value of the sum through modulus by 10.
                current.next = new ListNode(sum % 10);

                // Advance the outL1ut list.
                current = current.next;

                // Advance the input lists.
                if (L1 != null) L1 = L1.next;
                if (L2 != null) L2 = L2.next;
            }

            // Ensure the last curry is stored.
            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            // The output is the list after the dummy head node.
            return headNode.next;
        }
    }
}