using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class QueueCircular
    {
        private int[] queue;
        int rear = -1;
        int front = -1;
        int count;
        public QueueCircular(int cap)
        {
            queue = new int[cap];
        }
        void enqueue(int item)
        {
            if (count == queue.Length)
            {
                throw new Exception("Queue Is Full");
            }
            queue[rear] = item;
            rear = (rear + 1) % queue.Length;
            count++;
        }
        void Reverse(int[] a)
        {
            int[] reverse = new int[a.Length];
            for (int i = 0; i <= a.Length; i++)
                reverse[i] = a[a.Length - i - 1];
        }
        void dequeue()
        {
            var item = queue[front];
            queue[front] = 0;
            front = (front + 1) % queue.Length;
            count--;
        }
        Boolean IsEmpty()
        {
            return front == -1;
        }
        Boolean IsFull()
        {
            return (rear + 1) % queue.Length == front;
        }
        int peek()
        {
            if (IsEmpty())
                throw new Exception("Queu IS empty");
            return queue[front];
        }
    }
}
