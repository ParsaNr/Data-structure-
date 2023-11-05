using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Hanoi
    {
        void hanoi(int Disk, char Shoro, char payan, char temp)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"{Shoro} == {payan}");
            }
            else
            {
                hanoi(Disk - 1, Shoro, payan, temp);
                Console.WriteLine($"{Shoro} -== {payan}");
                hanoi(Disk - 1, temp, Shoro, payan);
            }
        }
    }
}
