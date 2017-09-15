using System;
namespace dedupConsecutive
{
    class ConsecutiveDup
    {
        public void checkConsecutive(int[] Array1)
        {
            int index ;
            int length = Array1.Length;
            for (index = 0; index < length - 1; index++)
            {
                if (Array1[index] == Array1[index + 1])
                {
                    for (int j = index+1; j < length-1; j++)
                    {
                        Array1[j] = Array1[j + 1];
                    }
                    index--;
                    length--;
                }
            }
            Console.WriteLine("result is");
            for ( index = 0; index < length; index++)
            {
                Console.WriteLine(Array1[index]);
            }
           
        }
    }
}
