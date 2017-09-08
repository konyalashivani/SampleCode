using System;
namespace randomizingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please do enter the elements of the array");
            int[] inputArray = new int[7];
            int indexOfInputArray;
            for(indexOfInputArray = 0; indexOfInputArray < inputArray.Length; indexOfInputArray++)
            {
                inputArray[indexOfInputArray] = Convert.ToInt32(Console.ReadLine());
            }
            RandomArrayClass RandomObject = new RandomArrayClass();
            RandomObject.randarray(inputArray);
            Console.ReadLine();      
        }
    }
}
