using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace powerprogram
{
    class power
    {
        public int calculatepower(int Base,int Exponent)
        {
            int Temp,result=1;
            Temp = Exponent;
            while (Temp > 0)
            {
                result = result * Base;
                Temp--;
            }
            return result;
        }
    }
}
