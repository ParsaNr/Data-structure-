using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MergeSort
    {
        public void mergesort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                mergesort(a, low, mid);
                mergesort(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static void Merge(int[] array, int low, int mid, int high)
        {
            var left = low;
            var right = mid + 1;
            var tempArray = new int[high - low + 1];
            var k = 0;

            while ((left <= mid) && (right <= high))
            {
                if (array[left] < array[right])
                {
                    tempArray[k] = array[left];
                    left++;
                }
                else
                {
                    tempArray[k] = array[right];
                    right++;
                }

                k++;
            }

            for (var i = left; i <= mid; i++)
            {
                tempArray[k] = array[i];
                k++;
            }

            for (var i = right; i <= high; i++)
            {
                tempArray[k] = array[i];
                k++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[low + i] = tempArray[i];
            }
        }
        public void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
