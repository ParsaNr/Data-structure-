using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Tarkib
    {
        int TB(int a, int b)
        {
            if (b == a || b == 0)
                return 1;
            else
                return TB(a - 1, b) + TB(a - 1, b - 1);
        }
    }
}
