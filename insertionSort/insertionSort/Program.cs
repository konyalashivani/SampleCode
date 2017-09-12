using System;
namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[8];
            int i;
            Console.WriteLine("please enter list of elements to be sorted");
            for(i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                    
            }
            sort s = new sort();
            s.insertionsort(a);
            Console.ReadLine();
            }
        }
    }

