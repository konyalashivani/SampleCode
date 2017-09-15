
using System;

namespace dedupList
{
    class dedupClass
    {
        public void removeduplications(int[] Array)
        {
            int index1, index2;

            int lengthOfArray = Array.Length;
            for (index1 = 0; index1 < lengthOfArray; index1++)
            {
                for (index2 = index1 + 1; index2 < lengthOfArray; index2++)
                {
                    if (Array[index1] == Array[index2])
                    {
                        for (int k = index2; k < lengthOfArray - 1; k++)
                        {
                            Array[k] = Array[k + 1];
                        }
                        index2--;
                        lengthOfArray--;
                    }
                }
            }
            Console.WriteLine("New Array After Removing Duplications :");
            for (int index = 0; index < lengthOfArray; index++)
            {
                Console.Write(" " + Array[index]);
            }
        }
    }
}