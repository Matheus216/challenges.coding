// See https://aka.ms/new-console-template for more information
using challenges.coding.core.services;
using System.Net.Http.Headers;
using System.Threading.Tasks.Sources;

var c = new Challenges();


//c.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));
c.AddTwoNumbers(new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))), new ListNode(9, new ListNode(9, new ListNode(9))));
//c.AddTwoNumbers(new ListNode(0), new ListNode(0));


public class Challenges

{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int sumMax = 0;

        var response = Recursive(l1, l2, sumMax);

        return response ?? new ListNode(); 
    }

        public ListNode Recursive(ListNode v, ListNode vnx, int sumMax)
        {
            if (vnx?.val > 0 || v?.val > 0)
            {
                ListNode response;
                var sum = (v?.val ?? 0) + (vnx?.val??0) + sumMax;
           
                if (sum >= 10)
                {
                    var dif = sum % 10;

                    sumMax = ValidBiggerTeen(sum);
                    response = new ListNode(dif); 
                }
                else 
                    response = new ListNode(sum);

                response.next = Recursive(v.next, vnx?.next, sumMax);
                return response;
            }

            return null;
        }

        public int ValidBiggerTeen(int sum)
        {
            var response = 0; 
            if (sum >= 10)
            {
                var rou = Convert.ToInt32(Math.Round((sum / 10M), 0));
                response += rou;

                ValidBiggerTeen(response);
            }

            return response; 
        }
}

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
