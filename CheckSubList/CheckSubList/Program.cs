using System;
namespace CheckSubList
{
    class Program
    {
        static void Main(string[] args)
        {
            int index1,index2;
            Console.WriteLine("please enter number of elements of array1");
            int Array1count = Convert.ToInt32(Console.ReadLine());
            int[] Array1 = new int[Array1count];
            for (index1=0;index1<Array1count;index1++)
            {
                Array1[index1]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("please enter number of elements of array2");
            int Array2count = Convert.ToInt32(Console.ReadLine());
            int[] Array2 = new int[Array2count];
            for (index2 = 0; index2 < Array2count; index2++)
            {
                Array2[index2] = Convert.ToInt32(Console.ReadLine());

            }
            Checkinglist Object = new Checkinglist();
            int result=Object.checkSublist(Array1,Array2, Array1count, Array2count);
            if(result==0)
                Console.WriteLine("array2 is not subset of array1");
            else
                Console.WriteLine("Array2 is subset of Array1");
            Console.ReadLine();
        }
    }
}
