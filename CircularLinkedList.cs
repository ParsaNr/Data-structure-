using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CircularLinkedList
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
        public void InsertAtFirst(int item)
        {
            node p = new node(item);
            p.next = null;
            if (isEmpty())
            {
                head = p;
                head.next = head;
            }
            p.next = head.next;
            head.next = p;
            size++;
        }
        public void InsertAtEnd(int item)
        {
            var node = new node(item);
            node.next = null;
            if (isEmpty())
                head = tail = node;
            else
            {
                node.next = head.next;
                head.next = node;
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
            else
            {
                var node = head.next;
                head.next = node.next;
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
                node q = head;
                while (q.next != head)
                    q = q.next;
                q.next = head.next;
            }
            size--;
        }
        public int SizeOfList()
        {
            return size;
        }
        public void invert()
        {
            var previuos = head;
            var current = head.next;
            while (current != head)
            {
                var next = current.next;
                current.next = previuos;
                previuos = current;
                current = next;
            }
            tail = head;
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
            while (current.next != head)
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
