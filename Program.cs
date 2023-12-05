using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    class LinkNode
    {
        public int value;
        public LinkNode next;
        public LinkNode(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
    static void position(int k, int n)
    {
        LinkNode first;
        first = new LinkNode(0);
        LinkNode prev;
        prev = first;
        int j = 0;
        while (j < n)
        {
            prev.next = new LinkNode(j);
            prev = prev.next;
            j++;
        }
        LinkNode add2 = first;
        LinkNode add1 = first;
        prev.next = first;

        while (add1.next != add1)
        {
            int c = 1;
            while (c != k)
            {
                add2 = add1;
                add1 = add1.next;
                c++;
            }
            add2.next = add1.next;
            add1 = add2.next;
        }
        Console.WriteLine(add1.value);
    }
    static public void Main(String[] args)
    {
        int k, n;
        n = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToInt32(Console.ReadLine());
        position(k, n);
        Console.ReadKey();
    }
}

