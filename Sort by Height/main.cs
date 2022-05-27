int[] solution(int[] a) {
    int minval;
    int minindex;
    int tempval;
    List<int> sortList = new List<int>();
    sortList = a.ToList();
    for(int i=0; i < sortList.Count;i++)
    {
        if (a[i]!=-1)
        {
            minval=sortList[i];
            minindex=i;
            for(int j=i; j<sortList.Count;j++)
            {
                if(sortList[j]<minval && sortList[j]!=-1)
                {
                    minval = sortList[j];
                    minindex = j;
                }
            }
            if(minval!=sortList[i])
            {
                tempval = sortList[i];
                sortList[i] = minval;
                sortList[minindex] = tempval;
            }
        }
    }
    return sortList.ToArray();
}
