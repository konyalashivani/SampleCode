using System;
namespace startsubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputString;
            Console.WriteLine("please enter the string wwith atleast 10 characters");
            InputString = Console.ReadLine();
            substringClass Object = new substringClass();
            Object.substringMethod(InputString);           
            Console.ReadKey();
        }
    }
}