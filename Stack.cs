using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Linked_List.linkedlist;

namespace ConsoleApp1
{
    class Stack
    {
        private node top;

        public bool isEmpty()
        {
            return top == null;
        }
        public void push(int item)
        {
            if (isEmpty())
            {
                Console.WriteLine("HeapOverFlow");
            }
            node temp = new node(item);
            temp.next = top;
            top = temp;
        }
        public void pop()
        {
            if (isEmpty())
            {
                Console.Write("\nStack Underflow");
            }
            top = top.next;
        }
        public int peek()
        {

            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

    }
}
