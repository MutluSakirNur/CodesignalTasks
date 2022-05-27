bool solution(int n) {
    char[] luckyTicket = n.ToString().ToCharArray();
    int half1 = 0;
    int half2 = 0;
    int halfsize = (luckyTicket.Length/2);
    for(int i=0; i<halfsize; i++)
    {
        half1 += luckyTicket[i];
        half2 += luckyTicket[i+halfsize];
    }
    if(half1 == half2)
        return true;
    else
        return false;
}
