namespace addinglist
{
    class listaddition
    {
        public int addelements(int SpecifiedNumber)
        {
            int index, sum = 0;
            for (index = 1; index <= SpecifiedNumber; index++)
            {
                sum = sum + index;
            }
            return sum;
        }
    }
}
