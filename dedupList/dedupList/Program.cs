using System;
namespace dedupList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please enter the length of array");
            int index;
            int ArrayLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the elements");

           
            int[] Array = new int[ArrayLength];
            for(index=0;index<ArrayLength;index++)
            {
                Array[index] = Convert.ToInt32(Console.ReadLine());
            }

            
            dedupClass Object = new dedupClass();
            Object.removeduplications(Array);
            Console.ReadLine();
        }
    }
}

