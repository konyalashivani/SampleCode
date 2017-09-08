using System;
namespace fibanocii
{
    class Program
    {
        static void Main(string[] args)
        {
            FibanociClass Object = new FibanociClass();
            Console.WriteLine("Enter number of elements u want in fibancii series");
            int NumberOfFibanociElements = Convert.ToInt16(Console.ReadLine());
            Object.fibanoci(NumberOfFibanociElements);
            Console.ReadLine();
        }
    }
}
