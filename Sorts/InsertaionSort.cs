using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InsertaionSort
    {
        public void Insertion(int[] a)
        {
            int n = a.Length;
            int j, temp;
            for (int i = 1; i < n; ++i)
            {
                temp = a[i];
                j = i - 1;
                while (j >= 0 && a[j] > temp)
                {
                    a[j + 1] = a[j];
                    j -= 1;
                }
                a[j + 1] = temp;
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
