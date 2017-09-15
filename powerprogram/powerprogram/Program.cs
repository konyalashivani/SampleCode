using System;
namespace powerprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            power p = new power();
            int Base, Exponent, PowerResult; ;
            Console.WriteLine("enter the base number");
            Base = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the exponent number");
            Exponent = Convert.ToInt16(Console.ReadLine());
            PowerResult=p.calculatepower(Base, Exponent);   
            Console.WriteLine("the result of the given base and exponent values is "+PowerResult);
            Console.ReadLine();
        }
    }
}
