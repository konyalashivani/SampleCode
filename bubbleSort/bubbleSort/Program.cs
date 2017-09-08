using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int index,j;
            int[] InputList = new int[6];
            Console.WriteLine("please enter the list of elements");
            for(index=0;index< InputList.Length;index++)
            {
                InputList[index]=Convert.ToInt32(Console.ReadLine());
            }
            bubble Object = new bubble();
            Object.bubblesortmethod(InputList);
            Console.ReadLine();
        }
    }
}
