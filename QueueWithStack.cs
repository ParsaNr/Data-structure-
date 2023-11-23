using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QueueWithStack
    {
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        public void Enqueue(int item)
        {
            stack1.Push(item);
        }

        public void Dequeue(int item)
        {
            if (IsEmpty())
                throw new Exception("Stack Is Empty");
            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            stack2.Pop();
        }

        public Boolean IsEmpty()
        {
            return (stack1.Count == 0 && stack2.Count == 0);
        }
    }
}
