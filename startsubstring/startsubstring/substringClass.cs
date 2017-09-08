using System;
namespace startsubstring
{
    class substringClass
    {
        public void substringMethod(string InputString)
        {
            int indexOfInputString, index, substringindex,count;
            string substringOfInputString = InputString.Substring(3, 4);
            Console.WriteLine("substring is " + substringOfInputString);
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
                                Console.WriteLine("start of substring is " + indexOfInputString);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
