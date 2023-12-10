using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Linked_List
    {
        public class linkedlist
        {
            public class node
            {
                public int data;
                public node next;
                public node(int value)
                {
                    this.data = value;
                    this.next = null;
                }
            }
            public node head;
            private node tail;
            private int size;
            private bool isEmpty()
            {
                return head == null;
            }
            private node getPrevious(node item)
            {
                var current = head;
                while (current != null)
                {
                    if (current.next == item) return current;
                    current = current.next;
                }
                return null;
            }
            public node GetNode(int data) => new node(data);
            public void InsetAtIndex(node headnode, int item, int index)
            {
                var head = headnode;
                if (index < 1)
                    Console.WriteLine("Invalid position");

                if (index == 1)
                {
                    var newNode = new node(item);
                    newNode.next = head;
                    head = newNode;
                }
                else
                {
                    while (index-- != 0)
                    {
                        if (index == 1)
                        {
                            node newNode = GetNode(item);

                            newNode.next = headnode.next;

                            headnode.next = newNode;
                            break;
                        }
                        headnode = headnode.next;
                    }
                    if (index != 1)
                        Console.WriteLine("Position out of range");
                }
                size++;
            }
            public void InsertAtEnd(int item)
            {
                var node = new node(item);
                if (isEmpty())
                    head = tail = node;
                else
                {
                    tail.next = node;
                    tail = node;
                }
                size++;
            }
            public void InsertAtFirst(int item)
            {
                var node = new node(item);
                if (isEmpty())
                    head = tail = node;
                else
                {
                    node.next = head;
                    head = node;
                }
                size++;
            }
            public void RemoveNodeAtIndex(int index)
            {
                node temp = head;
                if (isEmpty())
                    head = tail = temp;

                if (index == 0)
                {
                    head = temp.next;
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
            public void RemoveNodeAtBeggin()
            {
                if (isEmpty())
                    throw new Exception("No Element To Delete");
                if (head == tail)
                    head = tail = null;
                else
                {
                    var node = head.next;
                    head.next = null;
                    head = node;
                }
                size--;
            }
            public void RemoveNodeAtEnd()
            {
                if (isEmpty())
                    throw new Exception("No Element To Delete");
                if (head == tail)
                    head = tail = null;
                else
                {
                    var prev = getPrevious(tail);
                    tail = prev;
                    tail.next = null;
                }
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
                head = first;
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
                var previuos = head;
                var current = head.next;
                while (current != null)
                {
                    var next = current.next;
                    current.next = previuos;
                    previuos = current;
                    current = next;
                }
                tail = head;
                tail.next = null;
                head = previuos;
            }
            public void Update(int old, int New)
            {
                int index = 0;
                if (isEmpty())
                {
                    Console.WriteLine("There is no Item");
                }
                var current = head;
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
}
