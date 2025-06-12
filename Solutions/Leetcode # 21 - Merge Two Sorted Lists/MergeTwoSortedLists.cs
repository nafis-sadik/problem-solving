// Leetcode # 21 - Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists/submissions/1662257260
namespace MergeTwoSortedLists
{
    public class Solutions
    {
        /** Definition for singly-linked list. **/
        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode head = new ListNode(0);
            ListNode pointer = head;
            while (list1 != null && list2 != null)
            {
                if(list1.val < list2.val) {
                    pointer.val = list1.val;
                    list1 = list1.next;
                } else {
                    pointer.val = list2.val;
                    list2 = list2.next;
                }

                if(list1 != null || list2 != null)
                {
                    pointer.next = new ListNode(0);
                    pointer = pointer.next;
                }
            }

            ListNode? lPointer = list1 == null ? list2 : list1;
            if (lPointer != null)
            {
                pointer.val = lPointer.val;
                pointer.next = lPointer.next;
            }

            return head;
        }

        public bool Test(ListNode? list1, ListNode? list2, ListNode? expected)
        {
            ListNode? result = MergeTwoLists(list1, list2);
            while (expected != null && result != null)
            {
                if(expected.val != result.val)
                    return false;
                else
                {
                    expected = expected.next;
                    result = result.next;
                }
            }

            return true;
        }
    }
}