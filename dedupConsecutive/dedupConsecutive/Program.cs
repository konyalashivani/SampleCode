using System;
namespace dedupConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfElements;
            Console.WriteLine("please enter the length of Array");
            int.TryParse((Console.ReadLine()),out NoOfElements);
            int[] Array1 = new int[NoOfElements];
            Console.WriteLine("enter the elements");
            for(int index =0;index< NoOfElements;index++)
            {
               int.TryParse((Console.ReadLine()),out Array1[index]);
            }
            ConsecutiveDup Object = new ConsecutiveDup();
            Object.checkConsecutive(Array1);
            Console.ReadLine();
        }
    }
}
