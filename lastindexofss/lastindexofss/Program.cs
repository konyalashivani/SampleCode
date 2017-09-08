using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lastindexofss
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputString;
            int LastStartOsSubstring;
            Console.WriteLine("please enter the string wwith atleast 10 characters");
            InputString = Console.ReadLine();
            InputString.Trim();
            laststartofss Object = new laststartofss();
            LastStartOsSubstring = Object.indexcheck(InputString); 
            Console.WriteLine("Last start of substring in a string is " + LastStartOsSubstring);
            Console.ReadKey();
        }
    }
}

