using System;
namespace fibanocii
{
    class FibanociClass
    {
        public void fibanoci(int NumberOfFibanociElements)
        {
            int FirstElement, SecondElement , index,Result;
            FirstElement = 0;
            SecondElement = 1;
            Console.Write(FirstElement + " "+ SecondElement + " ");
            for(index=0;index< NumberOfFibanociElements; index++)
            {
                Result = FirstElement + SecondElement;
                FirstElement = SecondElement;
                SecondElement = Result;
                Console.Write(Result + " ");
            }
        }
    }
}
