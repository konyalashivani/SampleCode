using System;
namespace stringReversal
{
    class Program
    { 
        static void Main(string[] args)
        {
            Reverse rev = new Reverse();
            string originalString = Console.ReadLine();
            string reversestring=rev.reversestringMethod(originalString);
            Console.WriteLine("reversal of the string " + originalString + "  is  " + reversestring);
            Console.ReadLine();
        }
    }
}
