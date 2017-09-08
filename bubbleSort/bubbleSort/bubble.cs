using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubbleSort
{
    class bubble
    {
        public void bubblesortmethod(int[] InputList)
        {
            int NumberOfPasses,Index, temporaryVariable;
            for (NumberOfPasses = 0; NumberOfPasses < InputList.Length - 1; NumberOfPasses++)
            {
                for (Index = 0; Index < InputList.Length - 1; Index++)
                {
                    if (InputList[Index] > InputList[Index + 1])
                    {
                        temporaryVariable = InputList[Index];
                        InputList[Index] = InputList[Index + 1];
                        InputList[Index + 1] = temporaryVariable;

                    }
                }
            }
            Console.WriteLine("Bubble sorted list is ");
            for (Index = 0; Index < InputList.Length; Index++)
            {
                Console.Write(" " + InputList[Index]);
            }

        }
    }
}
