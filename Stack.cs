using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Stack
    {
        private int count;

        void Push(int[] items, int item)
        {
            if (count == items.Length)
                throw new Exception("Queue Is Full");
            items[count++] = item;
        }

        public int Pop(int[] items)
        {
            if (IsEmpty())
                throw new Exception("Queue Is Empty");
            return items[--count];
        }

        public int Peek(int[] items)
        {
            if (IsEmpty())
            {
                throw new Exception("Queue Is Empty");
            }
            return items[count - 1];
        }


        public Boolean IsEmpty()
        {
            if (count == 0)
                return true;
            return false;
        }
    }
}
