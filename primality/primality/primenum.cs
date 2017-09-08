namespace primality
{
    class primenum
    {
        public int checkprime(int number)
        {
            int index;
            for (index= 2;index<=(number/2);index++)
            {
                if (number% index == 0)
                {
                    return 0;
                }  
            }
            return 1;
        }
    }
}
