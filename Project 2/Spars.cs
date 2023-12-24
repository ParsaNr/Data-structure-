using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Spars
    {
        void spars(int[][] a, int row, int col)
        {
            int k = 1;
            int[,] spars = new int[100, 3];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    if (a[i][j] != 0)
                    {
                        spars[k, 0] = i;
                        spars[k, 1] = i;
                        spars[k, 2] = a[i][j];
                        k++;
                    }
                }
            spars[0, 0] = row;
            spars[0, 1] = col;
            spars[0, 2] = k - 1;
        }
    }
}
