using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _2direction_linked_list
    {
        public class node
        {
            public int data;
            public node next;
            public node previous;

            public node(int data)
            {
                this.data = data;
            }
        }
        public node firstnode;
        public node lastnode;
        private int size;
        private bool isEmpty()
        {
            return firstnode == null;
        }
        public node GetNode(int data) => new node(data);
        public void InsetAtIndex(int item, int index)
        {
            if (index < 1)
            {
                Console.WriteLine("Invalid Index");
            }
            if (index == 1)
            {
                node newnode = new node(item);
                newnode.next = firstnode;
                firstnode.previous = newnode;
            }
            else
            {
                while (index-- != 0)
                {
                    if (index == 1)
                    {
                        node newnode = GetNode(item);
                        newnode.next = firstnode.next;
                        firstnode.previous = newnode;
                        firstnode.next = newnode;
                        break;
                    }
                    firstnode = firstnode.next;
                    if (index != 1)
                        Console.WriteLine("Position out of range");
                }
            }
            size++;
        }
        public void InsertAtEnd(int item)
        {
            node newnode = new node(item);
            newnode.next = newnode.previous = null;
            var q = firstnode;
            if (isEmpty())
            {
                firstnode = newnode;
            }
            else
            {
                while (q.next != null)
                {
                    q = q.next;
                }
                newnode.previous = q;
                q.next = newnode;
                newnode.next = null;
            }
            size++;
        }
        public void InsertAtFirst(int item)
        {
            node newnode = new node(item);
            newnode.next = newnode.previous = null;
            if (isEmpty())
            {
                firstnode = newnode;
            }
            else
            {
                newnode.next = firstnode;
                firstnode.previous = newnode;
                firstnode = newnode;
            }
            size++;
        }
        public void RemoveNodeAtIndex(int index)
        {
            node temp = firstnode;
            if (isEmpty())
                firstnode = lastnode = temp;

            if (index == 0)
            {
                firstnode = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < index - 1; i++)
                temp = temp.next;

            if (temp == null || temp.next == null)
                return;

            node next = temp.next.next;

            temp.next = next;
            size--;
        }
        public void RemoveNodeAtEnd()
        {
            if (isEmpty())
                throw new Exception("No Element To Delete");
            if (firstnode == lastnode)
                firstnode = lastnode = null;
            else
            {
                node q = firstnode;
                while (q.next != null)
                    q = q.next;
                lastnode = q.previous;
                lastnode.next = null;
            }
            size--;
        }
        public void RemoveNodeAtBeggin()
        {
            if (isEmpty())
                throw new Exception("No Element To Delete");
            if (firstnode == lastnode)
                firstnode = lastnode = null;
            var node = firstnode.next;
            firstnode.next = null;
            firstnode = node;
            size--;
        }
        public int SizeOfList()
        {
            return size;
        }
        public void Concatenation(node first, node second)

        {
            if (int.Parse(first.next.data.ToString()) > int.Parse(second.data.ToString()))
            {
                node t = first;
                first = second;
                second = t;
            }
            firstnode = first;
            while ((first.next != null) && (second != null))
            {
                if (int.Parse(first.next.data.ToString()) < int.Parse(second.data.ToString()))
                {
                    first = first.next;
                }
                else
                {
                    node n = first.next;
                    node t = second.next;
                    first.next = second;
                    second.next = n;
                    first = first.next;
                    second = t;
                }
            }
            if (first.next == null)
                first.next = second;
        }
        public void invert()
        {
            var previuos = firstnode;
            var current = firstnode.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previuos;
                previuos = current;
                current = next;
            }
            lastnode = firstnode;
            lastnode.next = null;
            firstnode = previuos;
        }
        public void Update(int old, int New)
        {
            int index = 0;
            if (isEmpty())
            {
                Console.WriteLine("There is no Item");
            }
            var current = firstnode;
            while (current.next != null)
            {
                if (current.data == old)
                {
                    current.data = New;
                }
                current = current.next;
                index++;
            }
        }
    }
}
