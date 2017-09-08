using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace pangram
{
    class pangramclass
    {
        public int checkpangram(string Inputstring)
        {
            Inputstring = Inputstring.Trim();
            int lengthOfPangram = Inputstring.Length;
            
            if(lengthOfPangram<26)
            {
                return 0;
            }
            for (char character='A';character<='Z';character++)
            {

                if ((Inputstring.IndexOf(character) < 0) && (Inputstring.IndexOf((char)(character + 32)) < 0))
                {
                    return 0;
                }
                   
            }
            return 1;
        }
    }
}

