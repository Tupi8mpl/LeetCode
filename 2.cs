public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
}

// internal class Program
// {
//     public static void Main()
//     {
//         var l1 = new ListNode(1, new ListNode(1, new ListNode(1)));
//         var l2 = new ListNode(5, new ListNode(1));
//         var result = Solution.AddTwoNumbers(l1, l2);
//         while (result is not null)
//         {
//             Console.WriteLine(result.val);
//             result = result?.next;
//         }
//     }
// }

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = new ListNode(0, new ListNode());
        var current = result;
        var plus = 0;
        var prevNode = current;
        while (l1 is not null || l2 is not null || plus != 0)
        {
            var val1 = l1?.val ?? 0;
            var val2 = l2?.val ?? 0;
            current.val = (val1 + val2 + plus) % 10;
            plus = (val1 + val2 + plus) / 10;
            current.next = new ListNode();
            prevNode = current;
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        prevNode.next = null;
        return result;
    }
}