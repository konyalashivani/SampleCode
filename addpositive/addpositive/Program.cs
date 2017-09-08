using System;
namespace addpositive
{
    class Program
    {
        static void Main(string[] args)
        {
            add Object = new add();
            int NumberofElements=Convert.ToInt32(Console.ReadLine());
            int[] InputArray = new int[NumberofElements];
            int index;
            Console.WriteLine("enter the numbers");
            for(index = 0; index < InputArray.Length; index++)
            {
                InputArray[index] = Convert.ToInt32(Console.ReadLine());
            }
            Object.addmethod(InputArray);
            Console.ReadLine();
        }
    }
}
