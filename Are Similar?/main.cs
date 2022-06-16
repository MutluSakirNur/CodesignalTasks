bool solution(int[] a, int[] b) {
    if(a.Length != b.Length)
        return false;
    int tempfirstb = -1;
    int tempfirsta = -1;
    int swapcount=0;
    for(int i=0; i<a.Length; i++)
    {
        if(a[i] != b[i])
        {
            swapcount++;
            if(swapcount > 2)
                return false;
            if(swapcount == 1)
            {
                tempfirstb = b[i];
                tempfirsta = a[i];
            }
            else // if is 2
            {
                if(a[i] != tempfirstb || b[i] != tempfirsta)
                    return false;
            }
        }
    }
    return true;
}
