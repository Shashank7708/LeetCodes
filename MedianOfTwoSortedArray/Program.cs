using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArray
{
    internal class Program
    {
        public class ListNode
        {
      public int val;
      public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
                     }
  }

        static void Main(string[] args)
        {
            ListNode r1 = new ListNode(1);
            ListNode head = r1;
            ListNode r2 = new ListNode(2);
            r1.next = r2; ;
            ListNode r3 = new ListNode(3);
            r2.next = r3; ;
            ListNode r4 = new ListNode(4);
            r3.next = r4; ;
            ListNode r5 = new ListNode(5);
            r4.next = r5;
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode previous = null;
            ListNode current = slow;

            while (current != null)
            {
                ListNode nextNode = current.next;
                current.next = previous;
                previous = current;
                current = nextNode;
            }
            ListNode lastNode = previous;

            ListNode h1 = new ListNode(0);
            ListNode curr = h1;

            while (head != null && lastNode != null)
            {
                ListNode temp = head.next;
                curr.next = head;
                curr = head;
                head= temp;

                temp = lastNode.next;
                curr.next= lastNode;
                curr = lastNode;
                lastNode = temp;
                
               
            }

            if (head != null)
            {
                curr.next = head;
            }

            if (lastNode != null)
            {
                curr.next = lastNode;
            }

            head = h1.next;

        }
    }
}
