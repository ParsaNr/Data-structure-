using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Power
    {
        int pow(int a, int n)
        {
            if (n == 0)
                return 1;
            return pow(a, n - 1) * a;
        }
    }
}
