using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace randomizingArray
{
    class RandomArrayClass
    {
        public void randarray(int []inputArray)
        {
            Random rnd = new Random();
            int index;
            int[] ShuffledArray = inputArray.OrderBy(x => rnd.Next()).ToArray();
            Console.WriteLine("shuffled array is as below::");
            for(index=0;index<inputArray.Length;index++)
            {
                Console.Write(" "+ShuffledArray[index]);
            }
        }
    }
}
