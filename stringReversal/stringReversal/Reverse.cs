using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stringReversal
{
    class Reverse
    {
        public string reversestringMethod(string OriginalString)
        {
            string reversestring = "";
            int index = OriginalString.Length - 1;
            while (index >= 0)
            {
                reversestring = reversestring + OriginalString[index];
                index--;
            }
            return reversestring;
        }
    }
}
