using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Delete
    {
        int[] Remove(int[] a, int remove)
        {
            int c = 0;
            foreach (int n in a)
            {
                if (n == remove)
                {
                    c++;
                }
            }

            int[] update = new int[a.Length - c];
            int index = 0;
            foreach (int n in a)
            {
                if (n != remove)
                {
                    update[index] = n;
                    index++;
                }
            }

            return update;
        }
    }
}
