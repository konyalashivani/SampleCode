using System;
namespace addinglist
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("enter specified number");
            int SpecifiedNumber = Convert.ToInt32(Console.ReadLine());
            listaddition Object = new listaddition();
            sum= Object.addelements(SpecifiedNumber);
            Console.WriteLine("sum of numbers of list  is "+sum);
            Console.ReadLine();      
        }
    }
}
