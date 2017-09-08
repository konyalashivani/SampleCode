using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insertionSort
{
    class sort
    {
        public void insertionsort(int[]a)
        {
            int i,j;
            int[] t = new int[8];
            for (i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t[i] = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = t[i];
                    for (j = i; j >= 0 && i > 0; j--, i--)
                    {
                        if (a[i] < a[i - 1])
                        {
                            t[i - 1] = a[i - 1];
                            a[i - 1] = a[i];
                            a[i] = t[i - 1];
                        }
                    }
                }
            }
            Console.WriteLine("insertion sort order is ");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
        }
    }
}
