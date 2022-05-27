bool solution(int[] sequence) {
    int[] req = sequence;
    int result = control(req);
    if (result == -1)
        return true;
    else
    {
        req = req.Where((source, index) =>index != result).ToArray();
        if (control(req)==-1)
            return true;
        else
        {
            req = sequence.Where((source, index) =>index != result-1).ToArray();
            if (control(req)==-1)
                return true;
            else
                return false;
            
        }
    }
}

int control(int[] request)
{
    for(int i=1;i <request.Count(); i++)
    {
        if (request[i-1]>=request[i])
        return i;
    }
    return -1;
}
