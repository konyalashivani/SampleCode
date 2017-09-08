using System;
namespace addpositive
{
    class add
    {
        public void addmethod(int[] Inputarray)
        {
            int OutputArrayindex,sum=0;
            for (OutputArrayindex = 0; OutputArrayindex < Inputarray.Length; OutputArrayindex++)
            {
                if (Inputarray[OutputArrayindex] > 0)
                {
                    sum = sum + Inputarray[OutputArrayindex];
                }
            }
            Console.WriteLine("sum of all positive numbers is "+sum);
        }
    }
}
