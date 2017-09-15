namespace CheckSubList
{
    class Checkinglist
    {
        public int checkSublist(int[] Array1,int[] Array2,int Array1count,int Array2count)
        {
            int index1, index2;
            for(index2=0;index2<Array2count;index2++)
            {
                for(index1=0;index1<Array1count;index1++)
                {
                    if (Array1[index1] == Array2[index2])
                        break;
                }
                if (index1 == Array1count)
                    return 0;
            }
            return 1;
        }
    }
}