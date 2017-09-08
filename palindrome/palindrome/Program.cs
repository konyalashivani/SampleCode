using System;
namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            palindromeClass palindromeObject = new palindromeClass();
            string InputString = Console.ReadLine();
            palindromeObject.CheckPalindrome(InputString);
            Console.ReadLine();
        }
    }
}
