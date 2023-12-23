using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QuickSort
    {
        //public void quicksort(int[] arr, int low, int high)
        //{
        //    int j;
        //    if (low < high)
        //    {
        //        j = partition(arr, low, high + 1);
        //        quicksort(arr, low, j - 1);
        //        quicksort(arr, j + 1, high);
        //    }
        //}
        public int[] partition(int[] arr, int low, int high)
        {
            int i, j, pvot;
            pvot = arr[low];
            i = low;
            j = high;
            while (i <= j)
            {
                while (arr[i] < pvot)
                    i++;
                while (arr[j] > pvot)
                    j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (low < j)
                partition(arr, low, j);
            if (i < high)
                partition(arr, i, high);
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
