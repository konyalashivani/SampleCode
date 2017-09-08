using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palindrome
{
    class palindromeClass
    {
        public void CheckPalindrome(String InputString)
        {
            InputString.Trim();
            string reversestring = "";
            int index = InputString.Length - 1;
            while (index >= 0)
            {
                reversestring = reversestring + InputString[index];
                index--;
            }
            Console.WriteLine("Reversal of the string " + InputString + "  is  " + reversestring);
            if (InputString.Equals(reversestring))
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not a palindrome");
            }          
        }
    }
}
