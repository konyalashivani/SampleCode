using System;
namespace ApproximatingPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            int index,radius=1;
            float count = 0;
            for (index = 0; index < 10000; index++)
            {
                double x = Rand.NextDouble();
                double y = Rand.NextDouble();
               //circleEquation x^2+y^2=radius^2
                if(x*x+y*y<radius*radius)
                {
                    count = count + 1;
                }
            }
            // pi=4*NO of random points inside the circle/Total no of random points 
            float pi = 4 * count / 10000;
            Console.WriteLine("pi value is" + pi);
            Console.ReadLine();
        }
    }
}
