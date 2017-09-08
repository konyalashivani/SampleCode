using System;
namespace primality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number to be checked");
            int NumberTobeChecked = Convert.ToInt32(Console.ReadLine());
            primenum primeObject = new primenum();
            int Result=  primeObject.checkprime(NumberTobeChecked);
            if (Result == 0)
            {
                Console.WriteLine("number is not prime");
            }
            else
            {
                Console.WriteLine("num is prime");
            }
            Console.ReadLine();
        }
    }
}
