using System;
namespace pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            pangramclass pangramObject = new pangramclass();
            Console.WriteLine("enter the string ");
            string InputString = Console.ReadLine();
            int result=pangramObject.checkpangram(InputString);
            if(result==0)
            {
                Console.WriteLine("not a pangram");
            }
            else
            {
                Console.WriteLine("it is pangram");
            }
            Console.ReadLine();
        }
    }
}
