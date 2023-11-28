using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Josephus_Problem
    {
        public static int Loop(int N, int k)
        {
            int i = 1, ans = 0;

            while (i <= N)
            {
                ans = (ans + k) % i;
                i++;
            }

            return ans + 1;
        }
        int Recursion(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (Recursion(n - 1, k) + k - 1) % n + 1;
        }
        public static int Queue(int n, int k)
        {

            Queue<int> q = new Queue<int>();

            int i = 1;
            while (i <= n)
            {
                q.Enqueue(i);
                i++;
            }

            while (q.Count != 1)
            {
                int j = 1;
                while (j < k)
                {
                    int temp = q.Peek();
                    q.Enqueue(temp);
                    q.Dequeue();
                    j++;
                }

                q.Dequeue();
            }

            return q.Peek();
        }
    }
}
