bool solution(string inputString) {
    char temp;
    List<char> input = inputString.ToList();
    int rearrange = 0;
    int i=0;
    while(i<input.Count)
    {
        temp = input[i];
        input.RemoveAt(i);
        if(input.Contains(temp))
            input.Remove(temp);
        else
            rearrange++;
        i=0;
        if(rearrange > 1)
            return false;    
    }
    return true;
}
