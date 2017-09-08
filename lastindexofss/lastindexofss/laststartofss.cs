using System;
namespace lastindexofss
{
    class laststartofss
    {
        public int indexcheck(string InputString)
        {
            string substringOfInputString = InputString.Substring(3, 4);
            Console.WriteLine("substring is " + substringOfInputString);
            int indexOfInputString, index, substringindex;
            int [] LastStartOsSubstring = new int[1];
            for (indexOfInputString = 0; indexOfInputString < InputString.Length; indexOfInputString++)
            {
                if (InputString[indexOfInputString] == substringOfInputString[0])
                {
                    int IndexTillInputStringIschecked = indexOfInputString + substringOfInputString.Length;
                    for (index = indexOfInputString, substringindex = 0; index < IndexTillInputStringIschecked && substringindex < substringOfInputString.Length; substringindex++, index++)
                    {
                        if (InputString[index] == substringOfInputString[substringindex])
                        {
                            if (substringindex == substringOfInputString.Length - 1)
                            {
                                LastStartOsSubstring[0] = indexOfInputString;       
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return LastStartOsSubstring[0];
        }
    }
}
