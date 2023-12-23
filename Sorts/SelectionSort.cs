using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SelectionSort
    {
        public void selectionsort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int min = a[i];
                int k = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        k = j;
                    }
                }
                a[k] = a[i];
                a[i] = min;
            }
        }
        public void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
    }
}
