using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Queue
    {
        private int[] queue;
        int rear = -1;
        int front = -1;
        int count;
        public Queue(int cap)
        {
            queue = new int[cap];
        }
        void enqueue(int item)
        {
            if (count == queue.Length)
            {
                throw new Exception("Queue Is Full");
            }
            queue[rear++] = item;
            count++;
        }
        void dequeue()
        {
            var item = queue[front];
            queue[front++] = 0;
            count--;
        }
        void Reverse(int[] a)
        {
            int[] reverse = new int[a.Length];
            for (int i = 0; i <= a.Length; i++)
                reverse[i] = a[a.Length - i - 1];
        }
        void peek()
        {
            var item = queue[front];
        }
        Boolean IsFull(int front, int rear)
        {
            if (rear == front)
            {
                return true;
            }
            return false;
        }
        Boolean IsEmpty(int rear)
        {
            if (rear == -1 && front == -1)
            {
                return true;
            }
            return false;
        }


    }
}
