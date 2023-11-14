using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class BinarySearchandBubbleSort
    {
        public void sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = 1; j < a.Length; j++)
                    if (a[j] < a[j - 1])
                    {
                        var temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                    }
        }

        public int Find(int[] a, int n, int key)
        {
            int s = 0;
            int e = n;
            while (s <= n)
            {
                int mid = (s + e) / 2;
                if (a[mid] == key)
                {
                    return mid;
                }
                else if (a[mid] > key)
                {
                    e = mid - 1;
                }
                else
                {
                    s = mid + 1;
                }
            }
            return -1;
        }
    }
}
