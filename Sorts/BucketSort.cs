using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BucketSort
    {
        public int[] bucketsort(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            var index = 0;

            if (arr == null || arr.Length <= 1)
            {
                return arr;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            LinkedList<int>[] bucket = new LinkedList<int>[max - min + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (bucket[arr[i] - min] == null)
                {
                    bucket[arr[i] - min] = new LinkedList<int>();
                }
                bucket[arr[i] - min].AddLast(arr[i]);
            }

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<int> node = bucket[i].First;
                    while (node != null)
                    {
                        arr[index] = node.Value;
                        node = node.Next;
                        index++;
                    }
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
