using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CountingSort
    {
        public static int getmax(int[] arr, int n)
        {
            var max = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
        public int[] countingsort(int[] arr)
        {
            var n = arr.Length;
            var high = getmax(arr, n);
            var occurrences = new int[high + 1];

            for (int i = 0; i < high + 1; i++)
            {
                occurrences[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                occurrences[arr[i]]++;
            }

            for (int i = 0, j = 0; i <= high; i++)
            {
                while (occurrences[i] > 0)
                {
                    arr[j] = i;
                    j++;
                    occurrences[i]--;
                }
            }
            return arr;
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
