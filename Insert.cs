using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Insert
    {
        void insert(int[] a, int item, int index)
        {
            int[] arr = new int[a.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < index)
                {
                    arr[i] = a[i];
                }
                else if (i == index)
                {
                    arr[i] = item;
                }
                else
                {
                    arr[i] = a[i - 1];
                }
            }
        }
    }
}
